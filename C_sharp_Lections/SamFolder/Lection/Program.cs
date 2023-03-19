string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length)/2;
int screenHeightPosition = Console.WindowHeight/2;
void DrawText (string text, int left, int top)
{
    Console.SetCursorPosition(left,top);
    Console.WriteLine(text);
}
DrawText (caption, screenWidthPosition, screenHeightPosition);
DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
);
