using System;
namespace JaggedArrayRows {
 partial class JaggedArray {
 private int[][] jaggedArr = new int[4][];
 public void Display() {
 Console.WriteLine("Jagged Array:");
 for (int n = 0; n < jaggedArr.Length; n++) {
 Console.Write($"Row({n}): ");
 for (int k = 0; k < jaggedArr[n].Length; k++) {
 Console.Write($"{jaggedArr[n][k]} ");
 }
 Console.WriteLine();
 }
 Console.ReadKey();
 } }
 partial class JaggedArray {
 static void Main(string[] args) {
 JaggedArray jaggedArray = new JaggedArray();
 jaggedArray.jaggedArr[0] = new int[] { 1, 2, 3, 4 };
 jaggedArray.jaggedArr[1] = new int[] { 11, 34, 67 };
 jaggedArray.jaggedArr[2] = new int[] { 89, 23 };
 jaggedArray.jaggedArr[3] = new int[] { 0, 45, 78, 53, 99 };
 jaggedArray.Display();
 } } }
