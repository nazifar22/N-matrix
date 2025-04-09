This C# project implements a special square matrix type—called an N matrix—where only selected elements are allowed to be non-zero. Specifically, non-zero values are restricted to the following positions:
The main diagonal
The first column
The last column
All other elements are treated as zero and are not stored to save memory. The matrix is implemented using lists and only stores values that may be non-zero.
The project includes:
Representation of this special matrix structure
Methods to:
Get the value at a specific matrix index
Add two matrices
Multiply two matrices
Print the matrix in a full square shape
User input handling and a command-line interface for interaction
Custom exceptions for invalid inputs

Step 1: Launch the Program
Run the application. It starts by asking for the size of the square matrices (e.g., 3 for a 3×3 matrix).
Step 2: Enter Matrix Values
For each matrix, input:
All values on the main diagonal
All values in the first column (excluding the first one, since it's already in the diagonal)
All values in the last column (excluding the last one, already provided in the diagonal)
💡 Each input must be a comma-separated list of integers.
Step 3: Choose an Operation
After entering both matrices, select one of the following actions:
1. Get the entry value at a specific index
2. Add 2 matrices
3. Multiply 2 matrices
4. Print a matrix
