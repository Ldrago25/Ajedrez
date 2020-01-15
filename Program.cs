using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Proyecto4
{
    class Program
    {
        static bool reviso(String[] Tablero)
        {
            int x,y;
            x=-1;
            y=-1;
            x=Int16.Parse(Tablero[0]);
            y=Int16.Parse(Tablero[1]);
            if(x==0&&y==0) return true;
            return false;
        }
        static void juego(int n_tablero,String[] Tablero,String[] Queen,String[] Knight,String[] Pawn)
        {
            int n,m,Q,K,P;
            n=-1; m=-1; Q=-1; K=-1; P=-1;
            n=Int16.Parse(Tablero[0]);
            m=Int16.Parse(Tablero[1]);
            Q=Int16.Parse(Queen[0]);
            K=Int16.Parse(Knight[0]);
            P=Int16.Parse(Pawn[0]);
            int[,] matriz=new int[n,m];
            int iteras=0; int iter=0; int iteras_k=0; int iteras_k2=0; int interas_p=0; int iteras_p2=0; 
            iteras+=1;  iter+=2; iteras_k+=1; iteras_k2+=2; iteras_p2+=2; interas_p+=1;
          // Console.WriteLine("Tablero numero: "+n_tablero);
          // Console.ReadKey();
          // Console.WriteLine("Size of Queen: "+Q);
          // Console.WriteLine("Size of Knight: "+K);
          // Console.WriteLine("Size of Pawn: "+P);
           for (int i=0; i <matriz.GetLength(0); i++)
           {
               for(int j=0; j<matriz.GetLength(1); j++)
               {
                   matriz[i,j]=0;
               }
           }
           int[] vectorQ=new int[100];
           for(int i=0; i<Queen.Length; i++)
           {
               vectorQ[i]=Int16.Parse(Queen[i]);
           }
           
           int[] vectorK=new int[100];
           for(int i=0; i<Knight.Length; i++)
           {
               vectorK[i]=Int16.Parse(Knight[i]);
           }

           int[] vectorP=new int[100];
           for(int i=0; i<Pawn.Length; i++)
           {
               vectorP[i]=Int16.Parse(Pawn[i]);
           }
              int fila,columnaa;
              bool bandera=false;
             
              
              for (int y = 0; y <Q; y++)
              {
                  fila=vectorQ[iteras]-1;
                  columnaa=vectorQ[iter]-1;
                //  Console.WriteLine("Fila: "+fila);
                //  Console.WriteLine("Columna: "+columnaa);
                  for(int i=0; i<matriz.GetLength(0); i++)
                  {
                    for(int j=0; j<matriz.GetLength(1); j++)
                    {  
                        i=fila; j=columnaa;
                          if(matriz[i,j]==0)
                          {
                            matriz[i,j]=2;
                            iteras+=2;
                            iter+=2;
                            bandera=true;
                          }
                        if(bandera)break;
                    }
                     if(bandera)break;
                 }
                 fila=0; columnaa=0;
              }



              int fila_k,columnaa_k;
              bool banderak=false;
             
              
              for (int y = 0; y <K; y++)
              {
                  fila_k=vectorK[iteras_k]-1;
                  columnaa_k=vectorK[iteras_k2]-1;
                //  Console.WriteLine("FilaK: "+fila_k);
                //  Console.WriteLine("ColumnaK: "+columnaa_k);
                  for(int i=0; i<matriz.GetLength(0); i++)
                  {
                    for(int j=0; j<matriz.GetLength(1); j++)
                    {  
                        i=fila_k; j=columnaa_k;
                          if(matriz[i,j]==0)
                          {
                            matriz[i,j]=3;
                            iteras_k+=2;
                            iteras_k2+=2;
                            banderak=true;
                          }
                        if(banderak)break;
                    }
                     if(banderak)break;
                 }
                 fila_k=0; columnaa_k=0;
              }

              int fila_p,columnaa_p;
              bool banderap=false;
             
              
              for (int y = 0; y <P; y++)
              {
                  fila_p=vectorP[interas_p]-1;
                  columnaa_p=vectorP[iteras_p2]-1;
                //  Console.WriteLine("FilaP: "+fila_p);
                //  Console.WriteLine("ColumnaP: "+columnaa_p);
                  for(int i=0; i<matriz.GetLength(0); i++)
                  {
                    for(int j=0; j<matriz.GetLength(1); j++)
                    {  
                        i=fila_p; j=columnaa_p;
                          if(matriz[i,j]==0)
                          {
                            matriz[i,j]=1;
                            interas_p+=2;
                            iteras_p2+=2;
                            banderap=true;
                          }
                        if(banderap)break;
                    }
                     if(banderap)break;
                 }
                 fila_p=0; columnaa_p=0;
              }



            int it=0; int its=0; int filita,colu; bool banders=false;
            it+=1; its+=2;

            for(int y=0; y<Q; y++)
            {

            filita=vectorQ[it]-1;
            colu=vectorQ[its]-1;

            for(int i=0; i<matriz.GetLength(0); i++)
            {
                for(int j=0; j<matriz.GetLength(1); j++)
                {
                    i=filita; j=colu;
                    if(matriz[i,j]==2)
                    {
                       // Console.WriteLine("Entre a la reina");
                        while(i<n-1)
                        {
                            bool flag=false;
                          //  Console.WriteLine("Entre a la reina");
                            if(matriz[i+1,j]==0)
                            {
                               // Console.WriteLine("Entre a la reina");
                                matriz[i+1,j]=2;
                                i++;    
                            }else
                            {
                                flag=true;
                            }
                            if(flag) break;
                        }
                        i=filita; 
                         while(i>0)
                         {
                            bool flag=false;
                         //   Console.WriteLine("Entre a la reina");
                            if(matriz[i-1,j]==0)
                            {
                             //   Console.WriteLine("Entre a la reina");
                                matriz[i-1,j]=2;
                                i--;    
                            }else
                            {
                                flag=true;
                            }
                            if(flag) break;
                         }

                        i=filita;
                        while(j>0)
                         {
                            bool flag=false;
                         //   Console.WriteLine("Entre a la reina");
                            if(matriz[i,j-1]==0)
                            {
                              //  Console.WriteLine("Entre a la reina");
                                matriz[i,j-1]=2;
                                j--;    
                            }else
                            {
                                flag=true;
                            }
                            if(flag) break;
                        }
                        j=colu;

                          while(j<m-1)
                         {
                            bool flag=false;
                          //  Console.WriteLine("Entre a la reina");
                            if(matriz[i,j+1]==0)
                            {
                             //   Console.WriteLine("Entre a la reina");
                                matriz[i,j+1]=2;
                                j++;    
                            }else
                            {
                                flag=true;
                            }
                            if(flag) break;
                        }

                        j=colu;
                        while(i<n-1&&j<m-1)
                        {
                            bool flag=false;
                           // Console.WriteLine("Entre a la reina");
                            if(matriz[i+1,j+1]==0)
                            {
                            //    Console.WriteLine("Entre a la reina");
                                matriz[i+1,j+1]=2;
                                j++;    i++;
                            }else
                            {
                                flag=true;
                            }
                            if(flag) break;
                        }
                        i=filita;
                        j=colu;

                        while(i<n-1&&j>0)
                        {
                            bool flag=false;
                           // Console.WriteLine("Entre a la reina");
                            if(matriz[i+1,j-1]==0)
                            {
                            //    Console.WriteLine("Entre a la reina");
                                matriz[i+1,j-1]=2;
                                j--;    i++;
                            }else
                            {
                                flag=true;
                            }
                            if(flag) break;
                        }

                        i=filita;
                        j=colu;

                        while(i>0&&j<m-1)
                        {
                            bool flag=false;
                           //Console.WriteLine("Entre a la reina");
                            if(matriz[i-1,j+1]==0)
                            {
                            //Console.WriteLine("Entre a la reina");
                                matriz[i-1,j+1]=2;
                                j++;    i--;
                            }else
                            {
                                flag=true;
                            }
                            if(flag) break;
                        }

                        i=filita;
                        j=colu;


                        while(i>0&&j>0)
                        {
                            bool flag=false;
                           // Console.WriteLine("Entre a la reina");
                            if(matriz[i-1,j-1]==0)
                            {
                            //    Console.WriteLine("Entre a la reina");
                                matriz[i-1,j-1]=2;
                                j--;    i--;
                            }else
                            {
                                flag=true;
                            }
                            if(flag) break;
                        }
                        i=filita;
                        j=colu;

                        it+=2;
                        its+=2;
                        banders=true;
                    }
                
                    if(banders)break;   
                    }
                    if(banders)break;
                }
                filita=0; colu=0;
            }

             int ik=0; int iks=0; int cok; bool banderk=false; int f_c; int contas=0;
             ik+=1; iks+=2;
             for(int y=0; y<K; y++)
             {
                 f_c=vectorK[ik]-1;
                 cok=vectorK[iks]-1;
                for(int i=0; i<matriz.GetLength(0); i++)
                {
                    for(int j=0; j<matriz.GetLength(1); j++)
                    {
                        i=f_c; j=cok;
                        if(matriz[i,j]==3)
                        {
                           // Console.WriteLine("Knight");
                            while(i<n-1&&j>0)
                            {
                                bool bk=false;
                                if(matriz[i+1,j]!=4)
                                {
                                   i++;
                                   contas++;
                                   if(contas==2)
                                   {
                                       matriz[i,j-1]=3;
                                   }
                                }else
                                {
                                    bk=true;   
                                }
                                if(bk)break;
                            }
                            contas=0;
                            i=f_c; j=cok;

                            while(i<n-1&&j<m-1)
                            {
                                bool bk=false;
                                if(matriz[i+1,j]!=4)
                                {
                                    
                                    i++;
                                    contas++;
                                    if(contas==2)
                                    {
                                        matriz[i,j+1]=3;
                                    }

                                }else
                                {
                                    bk=true;
                                }
                                if(bk)break;
                            }

                            contas=0;
                            i=f_c; j=cok;


                            while(i>0&&j<m-1)
                            {
                                bool bk=false;
                                if(matriz[i-1,j]!=4)
                                {
                                    
                                    i--;
                                    contas++;
                                    if(contas==2)
                                    {
                                        matriz[i,j+1]=3;
                                    }

                                }else
                                {
                                    bk=true;
                                }
                                if(bk)break;
                            }

                            contas=0;
                            i=f_c; j=cok;



                            while(i>0&&j>0)
                            {
                                bool bk=false;
                                if(matriz[i-1,j]!=4)
                                {
                                    
                                    i--;
                                    contas++;
                                    if(contas==2)
                                    {
                                        matriz[i,j-1]=3;
                                    }

                                }else
                                {
                                    bk=true;
                                }
                                if(bk)break;
                            }

                            contas=0;
                            i=f_c; j=cok;


                            while(i>0&&j<m-1)
                            {
                                bool bk=false;
                                if(matriz[i,j+1]!=4)
                                {
                                    
                                    j++;
                                    contas++;
                                    if(contas==2)
                                    {
                                        matriz[i-1,j]=3;
                                    }

                                }else
                                {
                                    bk=true;
                                }
                                if(bk)break;
                            }

                            contas=0;
                            i=f_c; j=cok;

                            while(i<n-1&&j<m-1)
                            {
                                bool bk=false;
                                if(matriz[i,j+1]!=4)
                                {
                                    
                                    j++;
                                    contas++;
                                    if(contas==2)
                                    {
                                        matriz[i+1,j]=3;
                                    }

                                }else
                                {
                                    bk=true;
                                }
                                if(bk)break;
                            }

                            contas=0;
                            i=f_c; j=cok;


                            while(i>0&&j>0)
                            {
                                bool bk=false;
                                if(matriz[i,j-1]!=4)
                                {
                                    
                                    j--;
                                    contas++;
                                    if(contas==2)
                                    {
                                        matriz[i-1,j]=3;
                                    }

                                }else
                                {
                                    bk=true;
                                }
                                if(bk)break;
                            }

                            contas=0;
                            i=f_c; j=cok;

                            while(i<n-1&&j>0)
                            {
                                bool bk=false;
                                if(matriz[i,j-1]!=4)
                                {   
                                    j--;
                                    contas++;
                                    if(contas==2)
                                    {
                                        matriz[i+1,j]=3;
                                    }
                                }else
                                {
                                    bk=true;
                                }
                                if(bk)break;
                            }

                            contas=0;
                            i=f_c; j=cok;


                            ik+=2; iks+=2;
                            banderk=true;
                        }
                        
                        if(banderk)break;
                    }
                    if(banderk)break;
                }
                f_c=0; cok=0;
             }

            int contd=0;

             for(int i=0; i<matriz.GetLength(0);i++)
             {
                 for(int j=0; j<matriz.GetLength(1); j++)
                 {
                     if(matriz[i,j]==0)
                     {
                         contd++;
                     }
                 }
             }


           /* Console.WriteLine("Tablero con reina y caballo y peon");
            for(int i=0; i <matriz.GetLength(0); i++)
            {
               for(int j=0; j<matriz.GetLength(1); j++)
               {
                   Console.Write(" "+matriz[i,j]);
               }
               Console.WriteLine();
            }*/

            Console.WriteLine("Board: "+n_tablero+" Has "+contd+" Safes Squares!!");

        }



        static void Main(string[] args)
        {
            String nombre="Tablero.txt";
            String[] file=File.ReadAllLines(nombre);
            int itera=0;
            int contador=0;
            Console.WriteLine("!!Game of Brandon Vargas CI:26566047!!");
         
              while(true)
              {
                String[] tablero=file[itera].Split(' ');
                if(reviso(tablero))break;
                itera++;
                String[] Reina=file[itera].Split(' ');
                itera++;
                String[] Caballo=file[itera].Split(' ');
                itera++;
                String[] Peonn=file[itera].Split(' ');
                itera++;
                contador++;
                juego(contador,tablero,Reina,Caballo,Peonn);
               // Console.ReadKey();
             }
        }
    }
}
