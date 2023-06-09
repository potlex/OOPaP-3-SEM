using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //////-----------------------------------------// 5 LABA //--------------------------------------------//
            //Tiger tiger = new Tiger("white", "male", 1, "ground", "predator", 2008, 324);
            //Mammals mammal = new Lion("male", "ground", "predator", 3, 2014, 450);
            //Lion lion2 = new Lion("male", "ground", "predator", 7, 2004, 550);
            //Lion lion3 = new Lion("male", "ground", "predator", 8, 2017, 530);
            //Parrot parrot1 = new Parrot("yellow", "male", "harbivore", "sky", 2022, 0.21);
            //Realize Tom = new Realize("Tom", 19);
            //Printer printer = new Printer();
            //BaseClone baser = new Realize("Tim", 19);
            //Orca orca = new Orca(12, "female", "surface", "predator", 2018, 0.8);
            //List<Animal> animals2 = new List<Animal> { };
            //Zoo zoo = new Zoo();

            //zoo.animals = animals2;
            //zoo.Add(mammal);
            //zoo.Print();
            //zoo.Remove(mammal);
            //zoo.Print();

            //ArrayList list = new ArrayList();
            //list.Add(tiger);
            //list.Add(mammal);
            //list.Add(parrot1);
            //foreach (Animal item in list)
            //{
            //    Console.WriteLine(printer.IAmPrinting(item));
            //}

            //void CheckType(Tiger tigerExample)
            //{
            //    if (tigerExample is Mammals)
            //        Console.WriteLine("true");
            //    else
            //        Console.WriteLine("false");
            //}
            //void ReverseType(Tiger tigerExample)
            //{
            //    Mammals? mammalExample = tigerExample as Mammals;
            //    if (mammalExample == null)
            //        Console.WriteLine("null");
            //    else
            //        Console.WriteLine("not null");
            //}

            //CheckType(tiger);
            //ReverseType(tiger);

            //IAnimable iAnim;
            //iAnim = Tom;
            //iAnim.Info();
            //baser.Info();

            //Console.WriteLine(parrot1.ToString());

            //orca.InfoSize();

            //animals2.Add(lion2);
            //animals2.Add(lion3);
            //animals2.Add(orca);
            //Console.WriteLine(Controller.GetWeight<Lion>(zoo));

            ////-----------------------------------------// 6 LABA //--------------------------------------------//
            //for (int i = 1; i < 6; i++)
            //{
            //    try
            //    {
            //        switch (i)
            //        {
            //            case 1:
            //                Animal newAnimal = new Lion("female", "ground", "predator", 23, 2024, 410);
            //                break;
            //            case 2:
            //                Mammals newMammal = new Mammals(-1, "ground", "harbivore", 2018, 35);
            //                break;
            //            case 3:
            //                Owl newOwl = new Owl("non", "sky", "predator", 50, 100);
            //                break;
            //            case 4:
            //                int numA = 0;
            //                int numB = 5 / numA;
            //                break;
            //            case 5:
            //                int[] arrA = { 5, 55 };
            //                int cursorQ = arrA[4];
            //                break;
            //        }
            //    }
            //    catch (FException ex)
            //    {
            //        Console.WriteLine("");
            //        throw;
            //    }
            //    catch (SException ex)
            //    {
            //        Console.WriteLine("");
            //        throw;
            //    }
            //    catch (TException ex)
            //    {
            //        Console.WriteLine("");
            //        throw;
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Достигнут блок finally");
            //    }
            //}

            //int factorial(int n)
            //{
            //    Debug.Assert(n >= 0);
            //    Debug.Assert(n <= 10);
            //    if (n < 2)
            //    {
            //        return 1;
            //    }
            //    return factorial(n - 1) * n;
            //}
            //factorial(-10);

            //int[] aa = null;
            //Debug.Assert(aa != null, "Values array cannot be null");
            //-----------------------------------------// 7 LABA //--------------------------------------------//
            try
            {
                CollectionType<Lion> ct = new CollectionType<Lion>();
                Lion l1 = new Lion("female", "ground", "predator", 121, 2012, 322);
                Lion l2 = new Lion("female", "ground", "predator", 122, 2011, 367);
                Lion l3 = new Lion("male", "ground", "predator", 123, 2011, 351);
                Lion l4 = new Lion("male", "ground", "predator", 124, 2014, 410);
                List<Lion> ls1 = new List<Lion>() { l1, l2, l3 };

                ct.CCollection = ls1;
                ct.Show();
                ct.Add(l4);
                ct.Show();
                ct.Delete(l1);
                ct.Show();

                SaveFile<Lion>.WriteToFile(ct.CCollection);
                SaveFile<Lion>.ReadToFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Достигнут блок finally!");
            }
        }
    }
}
