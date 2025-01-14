import { Inter } from "next/font/google";
import "./globals.css";
import { MantineProvider, ColorSchemeScript } from "@mantine/core";
import "@mantine/core/styles.css";
import { Notifications } from "@mantine/notifications";

const inter = Inter({ subsets: ["latin"] });

export const metadata = {
  title: "Create Next App",
  description: "Generated by create next app",
};

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <head>
        <ColorSchemeScript />
      </head>
      <body
        className={`${inter.className} w-screen h-screen bg-wall overflow-x-hidden`}
      >
        <MantineProvider withGlobalSyles withNormalizeCss>
          <Notifications
            position="top-right"
            zIndex={1000}
            className="absolute top-4 right-4"
          />
          {children}
        </MantineProvider>
      </body>
    </html>
  );
}
