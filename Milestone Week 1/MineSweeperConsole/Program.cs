using System.ComponentModel.DataAnnotations;
using System.Data;
int row , collumn, bombs;

//-------------------------------------------------------------------

Console.WriteLine("Please Enter the number of Rows you want the Minefield To have (minumum 8");
row = Convert.ToInt32(Console.ReadLine());
if (row < 8)
{ row = 8; }//quick if statement to ensure the miniums are absolute
Console.WriteLine("Please enter the number of Collumns you want the Minefield to have (minimum 8");
collumn = Convert.ToInt32(Console.ReadLine());
if (collumn < 8) 
{  collumn = 8; }//quick if statement to ensure the miniums are absolute
Console.WriteLine("Please enter the number of bombs you want (Minimum 5 Recommended 12% easy 20% Medium Or 30% Hard");
bombs = Convert.ToInt32(Console.ReadLine());
if (bombs < 5)
{ bombs = 5; }//quick if statement to ensure the miniums are absolute


//Fun Fact this can only be called here and not earleir... that was fun to find out
int[,] minefield = new int[row, collumn];
//Place All Of the Supplied Bombs
for (int b = 0; b < bombs; b++)
{
    int y = Random.Shared.Next(row);
    int x = Random.Shared.Next(collumn);
    while (minefield[y,x] == 9)
        (y, x) = (Random.Shared.Next(row), Random.Shared.Next(collumn));
        minefield[y,x] = 9;

    for (int i = Math.Max(y - 1, 0); i <= Math.Min(y + 1, row - 1); i++)
        for (int j = Math.Max(x - 1, 0); j <= Math.Min(x + 1, collumn - 1); j++)
            if (minefield[i, j] != 9)
                minefield[i, j]++;
        
}
DrawMineField(minefield);
//Start the Game++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
GameResults result = GameResults.Continue;
while (result == GameResults.Continue)
{
    //Get The Coordniates From the Player
    int y, x;
    while(true)
    try
    {
    Console.Write("Enter the Y (up and down) Coordinate: ");
    y= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the X (left and right) Coordnite: ");
    x= Convert.ToInt32(Console.ReadLine());
            //Set the Limits for the MineField
            if (x >= 0 && y >= 0 && x < collumn && y < row)
                //Check for covered and uncovered Fields
                if (minefield[y, x] >= 0)
                    break;
                else
                    Console.WriteLine("This field is Uncovered, Select A Diffrent Field");
            else
                Console.WriteLine("Invalid coordnit, Select A New One");

    }
    catch
    {
            Console.WriteLine("Remember that Coordnates Must Be Valid Whole Numbers");
    }
    //Uncover Fileds as they are Selected
    //Remember to Check for Mine's First
    if (minefield[y, x] == 9)
    {
        for (int i = 0; i < row; i++)
            for (int j = 0; j < collumn; j++)
                if (minefield[i, j] >= 1 && minefield[i, j] <= 9)
                    minefield[i, j] *= -1;
                else if (minefield[i, j] == 0)
                    minefield[i, j] = -10;
        result = GameResults.Loss;
    }
    else if (minefield[y, x] >= 0)
        UncoverFields(y, x, minefield);

    //Time To Veryify Winnings

    if (result == GameResults.Continue)
    {
        result = GameResults.Win;
        foreach(int field in minefield)
            if (field >=0 && field != 9)
            {
                result = GameResults.Continue;
                break;
            }
    }
        //redraw the filed after every move
        DrawMineField(minefield);
}

//Game Has Ended Scenerios
if (result == GameResults.Loss)
{

    Console.WriteLine("You have become the LOSS");
}
if(result == GameResults.Win)
{

    Console.WriteLine("You have become the are winnings");
}


static void DrawMineField(int[,] minefield)
{

    Console.Clear();
    Console.Write("   | ");
    for (int j = 0; j < minefield.GetLength(1); j++)
        Console.Write("{0,2} ", j);

    Console.WriteLine();
    Console.WriteLine("---+-".PadRight(minefield.GetLength(1) * 3+5, '-'));

    for (int i = 0; i < minefield.GetLength(0); i++)
    {
        Console.Write("{0,2} | ", i);
        for (int j = 0; j < minefield.GetLength(1); j++)
        {
            //Cover the field Cuz zeing the Bombs ruins the purpose of the game
            if (minefield[i, j] >= 0)
                Console.Write(" ? ");
            //Empty Field
            else if (minefield[i, j] == -10)
                Console.Write(" . ");
            //Bomb Field
            else if (minefield[i, j] == -9)
                Console.Write("B");
            //Number'd Field
            else
                Console.Write(" {0} ", -minefield[i,j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}//End Of the Field Drawing

void UncoverFields(int i, int j, int[,] minefield)
{
    if(i >= 0 && j >= 0 && i <minefield.GetLength(0) && j < minefield.GetLength(1))
    {
        if (minefield[i, j] == 0)
        {
            minefield[i, j] = -10;
            //Uncover Nearby Fields aswell
            for (int y = -1; y <= 1; y++)
                for (int x = -1; x <= 1; x++)
                    UncoverFields(i + y, j + x, minefield);
        }
        else if (minefield[i, j] > 0 && minefield[i, j] < 9)
            minefield[i, j] *= -1;
    }
}

enum GameResults { Continue, Win, Loss}

