using System;


namespace Matrix
{
	class App
	{
		static void Main(string[] args)
		{
			//Matrix attributes
			byte x, y;
			x = y = 0;

			//Set amount for matrix rows
			MatrixSetup.SetMatrixAttribute(ref x, "rows");
			Console.WriteLine();

			//Set amount for matrix columns
			MatrixSetup.SetMatrixAttribute(ref y, "columns");

			//Create a default matrix
			int[,] userMatrix = new int[x, y];
			//Create a default transparent matrix
			int[,] transMatrix = new int[y, x];

			//Fill in matrix
			MatrixSetup.SetMatrixMembersManually(ref userMatrix);

			//User's Matrix output
			Console.WriteLine("Your matrix is: ");
			Console.WriteLine();
			MatrixSetup.TypeMatrix(userMatrix);

			//Set Transposed Matrix
			MatrixSetup.SetTransMatrixMembersFromAnotherMatrix(ref transMatrix, userMatrix);

			//Transposed Matrix output
			Console.WriteLine("Transpose of a matrix: ");
			Console.WriteLine();
			MatrixSetup.TypeMatrix(transMatrix, "reverse");

			Console.ReadKey();
		}
	}
}
