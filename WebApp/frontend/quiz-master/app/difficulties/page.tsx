"use client";

import Pagination from "@/components/Commons/Pagination";
import SearchField from "@/components/Commons/SearchField";
import CreateDifficultyModal from "@/components/Commons/modals/CreateDifficultyModal";
import PromptModal from "@/components/Commons/modals/PromptModal";
import DifficultiesTable from "@/components/Commons/tables/DifficultiesTable";
import {
    DifficultyResourceParameter,
    PaginationMetadata,
    QuestionDifficulty,
    QuestionResourceParameter,
} from "@/lib/definitions";
import { patchDifficulty, removeDifficulty } from "@/lib/hooks/difficulty";
import { notification } from "@/lib/notifications";
import { fetchDifficulties } from "@/lib/quizData";
import { PlusIcon } from "@heroicons/react/24/outline";
import { Anchor, Breadcrumbs, Button, Text } from "@mantine/core";
import { useForm } from "@mantine/form";
import Link from "next/link";
import { useCallback, useEffect, useState } from "react";

const items = [
    { label: "All", href: "#" },
    { label: "", href: "#" },
].map((item, index) => (
    <Anchor href={item.href} key={index}>
        <p className="text-black">{item.label}</p>
    </Anchor>
));

export default function Page() {
    const [createDifficulty, setCreateDifficulty] = useState(false);
    const [difficulties, setDifficulties] = useState<QuestionDifficulty[]>([]);
    const [searchQuery, setSearchQuery] = useState<string>("");
    const [deleteDifficulty, setDeleteDifficulty] = useState<
        QuestionDifficulty | undefined
    >();
    const [editDifficulty, setEditDifficulty] = useState<
        QuestionDifficulty | undefined
    >();
    const [paginationMetadata, setPaginationMetadata] = useState<
        PaginationMetadata | undefined
    >();

    const form = useForm<DifficultyResourceParameter>({
        initialValues: {
            pageSize: "10",
            searchQuery: "",
            pageNumber: 1,
        },
    });

    useEffect(() => {
        var questionsFetch = fetchDifficulties(form.values);
        questionsFetch.then((res) => {
            setDifficulties(res.data);
            setPaginationMetadata(res.paginationMetadata);
        });
    }, [form.values, createDifficulty]);

    const handleSearch = useCallback(() => {
        form.setFieldValue("searchQuery", searchQuery);
    }, [searchQuery, form]);

    const handleDelete = useCallback(() => {
        console.log("DELETE DIFFICULTY");
        if (deleteDifficulty) {
            removeDifficulty({ id: deleteDifficulty?.id })
                .then(() => {
                    setDifficulties((state) => {
                        var copy = state;
                        const index = copy.findIndex(
                            (qDifficulty) =>
                                qDifficulty.id === deleteDifficulty.id
                        );
                        copy.splice(index, 0);
                        return copy;
                    });
                    notification({
                        type: "success",
                        title: `${deleteDifficulty.qDifficultyDesc} difficulty succesfully deleted.`,
                    });
                })
                .catch(() => {
                    notification({
                        type: "error",
                        title: "Failed to delete difficulty.",
                    });
                })
                .finally(() => {
                    setDeleteDifficulty(undefined);
                });
        }
    }, [deleteDifficulty]);

    const handleEdit = useCallback(
        async (qCategoryDesc: string) => {
            if (editDifficulty) {
                patchDifficulty({
                    id: editDifficulty?.id,
                    patchRequest: [
                        {
                            path: "qDifficultyDesc",
                            op: "replace",
                            value: qCategoryDesc,
                        },
                    ],
                })
                    .then(() => {
                        setDifficulties((state) => {
                            var copy = state;
                            const index = copy.findIndex(
                                (qCategory) =>
                                    qCategory.id === editDifficulty.id
                            );
                            copy[index].qDifficultyDesc = qCategoryDesc;
                            return copy;
                        });
                        notification({
                            type: "success",
                            title: "Category succesfully updated.",
                        });
                    })
                    .catch(() => {
                        notification({
                            type: "error",
                            title: "Failed to update category.",
                        });
                    })
                    .finally(() => {
                        setEditDifficulty(undefined);
                    });
            }
        },
        [editDifficulty]
    );

    return (
        <div className="flex flex-col px-6 md:px-16 md:pb-20 py-5 space-y-5 grow">
            <Breadcrumbs>{items}</Breadcrumbs>
            <div className="flex">
                <Button
                    className="flex h-[40px] bg-[--primary] items-center gap-3 rounded-md py-3 text-white text-sm font-medium justify-start px-3"
                    color="green"
                    onClick={() => setCreateDifficulty(true)}
                >
                    <PlusIcon className="w-6" />
                    <p className="block">Create Difficulty</p>
                </Button>
                <div className="grow"></div>

                <SearchField
                    value={searchQuery}
                    onChange={(e) => {
                        setSearchQuery(e.target.value);
                    }}
                    onKeyDown={(e) => {
                        if (e.code === "Enter") {
                            handleSearch();
                        }
                    }}
                />
            </div>
            <DifficultiesTable
                difficulties={difficulties}
                onDelete={(dif) => setDeleteDifficulty(dif)}
                onEdit={(dif) => setEditDifficulty(dif)}
                message={
                    form.values.searchQuery
                        ? `No difficulties match \"${form.values.searchQuery}\"`
                        : difficulties.length === 0
                          ? "No Difficulties"
                          : undefined
                }
            />
            <Pagination form={form} metadata={paginationMetadata} />
            <CreateDifficultyModal
                opened={createDifficulty || editDifficulty !== undefined}
                onClose={() => {
                    setCreateDifficulty(false);
                    setEditDifficulty(undefined);
                }}
                difficulty={editDifficulty}
                onUpdate={handleEdit}
            />
            <PromptModal
                body={
                    <div>
                        <Text>Are you sure want to delete.</Text>
                        <div>{deleteDifficulty?.qDifficultyDesc}</div>
                    </div>
                }
                action="Delete"
                onConfirm={handleDelete}
                opened={deleteDifficulty ? true : false}
                onClose={() => {
                    setDeleteDifficulty(undefined);
                }}
                title="Delete Difficulty"
            />
        </div>
    );
}
