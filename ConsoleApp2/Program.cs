using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum P
    {
       /* byte pos,
        string color,
        bool stat,
        byte id*/
    //King(pos=22,color,stat);
    }
    class Program
    {
        //Кортеж
        /*static Tuple<byte, string, bool,int> Corteg(byte a, bool c,int aa)
        {
            byte a1 = 22;
            string a2 = "WHITE";
            bool a3 = true;
            int aa4 = 5+aa;
            return Tuple.Create < byte, string, bool, int >(a1,a2,a3,aa4);
        }*/
        static void Main(string[] args)
        {
            /*PP W_KING = new PP();
            W_KING.pos = 95;
            W_KING.color = "WHITE";
            W_KING.stat = true;
            W_KING.id = 2;
            W_KING.aas =new object {95, "WHITE",true,2};*/

            int[,] b = new int[8, 8];
            byte[] a =
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // 1-10
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // 11-20
                0, 1, 1, 1, 1, 1, 1, 1, 1, 0, // 21-30
                0, 1, 1, 1, 1, 1, 1, 1, 1, 0, // 31-40
                0, 1, 1, 1, 1, 1, 1, 1, 1, 0, // 41-50
                0, 1, 1, 1, 1, 1, 1, 1, 1, 0, // 51-60
                0, 1, 1, 1, 1, 1, 1, 1, 1, 0, // 61-70
                0, 1, 1, 1, 1, 1, 1, 1, 1, 0, // 71-80
                0, 1, 1, 1, 1, 1, 1, 1, 1, 0, // 81-90
                0, 1, 1, 1, 1, 1, 1, 1, 1, 0, // 91-100
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // 101-110
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0  // 111-120
            };
            //byte aa = 2;
            //a[22] = aa;
            //object[] pie = { aa2.};
            //var W_King = Corteg(23,false,8);
            

            byte l = 0;
            /*for (int i = 0; i < a.Length; i++)
            {
                if (i == W_KING.pos && a[i] != 0)
                {
                    a[i] = W_KING.id;
                    break;
                }
            }
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    Console.Write(a[l++]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            l = 0;
            Console.WriteLine();*/


            string u = "Введено";
            //постановка фигуры на поле
            link1:

            sbyte[] pm_king = { +11, +10, +9, +1, -1, -9, -10, -11 };


            /*PP[] tes = new PP[5];
            tes[0].name = "W_KING";
            tes[0].pos = 95;
            tes[0].color = "WHITE";
            tes[0].stat = true;
            tes[0].id = 2;
            tes[0].cost = 0;

            for (int i = 0; i < tes.Length; i++)
            {
                if (tes[i].pos == 94)
                {

                }
            }*/

            Piece W_KING = new Piece();
            W_KING.pos = 95;
            W_KING.color = "WHITE";
            W_KING.stat = true;
            W_KING.id = 2;

            Piece B_KING = new Piece();
            B_KING.pos = 25;
            B_KING.color = "BLACK";
            B_KING.stat = true;
            B_KING.id = 2;

            Piece W_KNIGHT = new Piece();
            W_KNIGHT.pos = 93;
            W_KNIGHT.color = "BLACK";
            W_KNIGHT.stat = true;
            W_KNIGHT.id = 3;

            Piece B_KNIGHT = new Piece();
            B_KNIGHT.pos = 23;
            B_KNIGHT.color = "BLACK";
            B_KNIGHT.stat = true;
            B_KNIGHT.id = 3;
            

            //var sp = from Piece1 in Piece where Piece.pos = 23 select Piece1;

            //ep - это желаемая позиция на которую необходимо поставить фигуру
            byte ep = 21;
            Console.WriteLine("Введите позицию");

            int CC = Int32.Parse(Console.ReadLine());
            ep = Convert.ToByte(CC);

            bool color_move = true;
            if (u == "Введено")
            {
                if (color_move == true)
                {
                    ep -= W_KING.pos;
                    color_move = false;
                }
                else if(color_move==false)
                {
                    ep -= B_KING.pos;
                    color_move = true;
                }

                //проверка хода по соответствию фигуры
                bool Ok_pm = false;
                for (int i = 0; i < pm_king.Length; i++)
                {
                    if (ep == pm_king[i])
                    {
                        Ok_pm = true;
                        break;
                    }
                    else if(i==pm_king.Length)
                    {
                        Console.WriteLine("Фигура так не ходит!");
                        Ok_pm = false;
                    }
                }
                if(Ok_pm == false)
                {
                    Console.WriteLine("Фигура так не ходит!");
                    goto link1;
                }
                if (Ok_pm == true)
                {
                    //перемещение фигуры на указанную позицию
                    W_KING.pos += ep;

                    for (int i = 0; i < a.Length; i++)
                    {
                        //проверка на выход за пределы доски
                        if (i == W_KING.pos - 1 && a[i] != 0)
                        {
                            a[i] = W_KING.id;
                            break;
                        }
                        else if (i == W_KING.pos - 1 && a[i] == 0)
                        {
                            Console.WriteLine("Выход за границу поля!");
                            //break;
                            goto link1;
                        }
                    }
                }
            }

            //вывод доски в консоль
            //byte l = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(a[l++]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public class Piece
        {
            public byte pos;
            public string color;
            public bool stat;
            public byte id;
        }
        public void aa2(byte pos, string color,bool stat)
        {
            
        }
    }
}
