Editor is a lightweight desktop text editor built with C# and Windows Forms on .NET 10.

Features

File menu: New, Open, Save, Save As, and Exit, using standard Windows file dialogs filtered to .txt files.
Formatting: choose the font and text color from the Edit menu using the standard Font and Color dialogs.
Persistent formatting: plain .txt files can’t store styling, so each save also writes a sidecar .xml file next to the text file (same name) with the font name, size, style, color, and a copy of the text. When you open the .txt, the editor looks for that .xml and reapplies the saved formatting automatically. The XML is read and written with LINQ to XML.
Live word counter: the status bar updates as you type, and clicking it opens a dialog with word, character, and paragraph counts.

How to use: open Editor.slnx in Visual Studio 2022 or later (requires the .NET 10 SDK on Windows) and run. Save a document, and you’ll see both name.txt and name.xml created in the same folder.
