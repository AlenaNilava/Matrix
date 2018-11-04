using System;

namespace Matrix
{
	class MatrixSetup
	{
		static int rows;
		static int columns;

		//Set Matrix Mainn Attribute
		public static void SetMatrixAttribute(ref byte attribute, string attributeName)
		{
			bool isValidValue = false;

			while (isValidValue == false)
			{
				try
				{
					Console.WriteLine($"Enter the number for {attributeName} amount");
					attribute = Byte.Parse(Console.ReadLine());
					isValidValue = true;
				}
				catch
				{
					Console.WriteLine("Wrong input.");
					Console.WriteLine();
				}
			}
		}

		//Fill in matrix manually
		public static void SetMatrixMembersManually(ref int[,] matrix)
		{
			SetMatrixAttributes(matrix);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					SetValue:
					Console.Write("Enter elements of the matrix with coordinates: [" + (i + 1) + ":" + (j + 1) + "]");
					try
					{
						matrix[i, j] = Int32.Parse(Console.ReadLine());
					}
					catch
					{
						Console.Write("Your input for: [" + (i + 1) + ":" + (j + 1) + "] is too small or too big, or not a number. Please, try again\n");
						goto SetValue;
					}
				}
				Console.WriteLine();
			}
		}

		//Fill in matrix from another matrix
		public static void SetTransMatrixMembersFromAnotherMatrix(ref int[,] finalMatrix, int[,] userMatrix)
		{
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					finalMatrix[j, i] = userMatrix[i, j];
				}
				Console.WriteLine();
			}
		}

		// set global rows and columns
		static void SetMatrixAttributes(int[,] matrix)
		{
			rows = matrix.GetUpperBound(0) + 1;
			columns = matrix.Length / rows;
		}

		//Display matrix
		public static void TypeMatrix(int[,] matrix, string mode = null)
		{
			if(mode != null)
			{
				int temp = rows;
				rows = columns;
				columns = temp;
			}

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write(matrix[i, j] + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}
