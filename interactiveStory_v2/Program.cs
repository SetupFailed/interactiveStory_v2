using Raylib_cs;

int widthX = 1600;
int heightY = 900;



void choiceCircles(){
  Raylib.DrawCircle(450,heightY-200,75,Color.WHITE);
  Raylib.DrawCircle(widthX-450, heightY-200,75,Color.WHITE);
}

void character(){
  Raylib.DrawCircle(widthX/2,heightY-200,30,Color.WHITE);
}

Raylib.InitWindow(widthX, heightY, "The title of my window");
Raylib.SetTargetFPS(60);



while (!Raylib.WindowShouldClose())
{
  Raylib.BeginDrawing();
  
  Raylib.ClearBackground(Color.BLACK);
  
  character();

  choiceCircles();  
  
  Raylib.EndDrawing();
}
