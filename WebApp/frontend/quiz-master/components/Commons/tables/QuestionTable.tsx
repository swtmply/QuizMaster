import { Question } from "@/lib/definitions";
import { fetchQuestions } from "@/lib/quizData";
import { questionTableColumns } from "@/lib/tableColumns";
import { EllipsisVerticalIcon } from "@heroicons/react/24/outline";
import { Checkbox, Table } from "@mantine/core";
import { useEffect, useState } from "react";

export default function QuestionTable({
    questions,
}: {
    questions: Question[];
}) {
    const [selectedRows, setSelectedRows] = useState<number[]>([]);

    const rows = questions.map((question) => (
        <Table.Tr
            key={question.id}
            bg={
                selectedRows.includes(question.id)
                    ? "var(--primary-100)"
                    : undefined
            }
        >
            <Table.Td>
                <Checkbox
                    color="green"
                    aria-label="Select row"
                    checked={selectedRows.includes(question.id)}
                    onChange={(event) =>
                        setSelectedRows(
                            event.currentTarget.checked
                                ? [...selectedRows, question.id]
                                : selectedRows.filter(
                                      (id) => id !== question.id
                                  )
                        )
                    }
                />
            </Table.Td>
            <Table.Td>{question.qStatement}</Table.Td>
            <Table.Td>{question.qTypeId}</Table.Td>
            <Table.Td>{question.qCategoryId}</Table.Td>
            <Table.Td>{question.qDifficultyId}</Table.Td>
            <Table.Td>
                <EllipsisVerticalIcon className="w-6" />
            </Table.Td>
        </Table.Tr>
    ));

    return (
        <div className="w-full border-2 rounded-xl overflow-x-auto grow bg-white">
            <Table striped>
                <Table.Thead>
                    <Table.Tr>
                        <Table.Th>
                            <Checkbox
                                color="green"
                                aria-label="Select row"
                                checked={
                                    selectedRows.length === questions.length
                                }
                                onChange={(event) =>
                                    setSelectedRows(
                                        event.currentTarget.checked
                                            ? questions.map(
                                                  (question) => question.id
                                              )
                                            : []
                                    )
                                }
                            />
                        </Table.Th>
                        <Table.Th>Question Statement</Table.Th>
                        <Table.Th>Type</Table.Th>
                        <Table.Th>Category</Table.Th>
                        <Table.Th>Difficulty</Table.Th>
                    </Table.Tr>
                </Table.Thead>
                <Table.Tbody>{rows}</Table.Tbody>
            </Table>
        </div>
    );
}
