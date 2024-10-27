# AxionBio Software Conference Oct 2024: Coding Challenge

## Coding Exercises

There are several coding tasks organized as the `Challenge` project.  
Please implement appropriate methods to pass the unit tests (check the `Tests` project).

The more tests are ✅, the better.  
🤖 Please **don't use LLM/AI helpers;** that kills the fun. 🤖 

### 1. AnagramChecker

Implement a method that checks if two strings are anagrams of each other.
Two strings are anagrams if they contain the same characters with the same frequencies, ignoring spaces and case.

```csharp
var ac = new AnagramChecker();
ac.AreAnagrams("Listen", "Silent"); // True
ac.AreAnagrams("Lis ten", "Silent"); // True
ac.AreAnagrams("Dont", "Listen"); // False
```

### 2. Maximal Depth of Binary Tree

Given a binary tree (check the class `BinaryTree\BinaryNode`),
return the number of edges between the root node and the deepest leaf node.

```
           A
        /     \
      B         C
     / \       / \
    D   E     F   G
       / \
      H   I
           \
            J

    # Deepest path: A-B-E-I-J
    # MaxDepth = 4
```

### 3. Find Alternating Bits

Implement a method that can detect if the binary form of an integer has 'alternating bits'.

A number has 'alternating bits' if each '1' in the binary form of the integer has two '0's as neighbors, and each '0' has two '1's as neighbors.  If a '1' or a '0' is in the least significant position, it only needs a single neighbor of the complementary digit.

You may ignore leading 0s.

For example

```csharp
  Assert.That(BitAlternator.IntegerHasAlternatingBits(0b101), Is.True); // True
  Assert.That(BitAlternator.IntegerHasAlternatingBits(0b10101), Is.True); // True
  Assert.That(BitAlternator.IntegerHasAlternatingBits(0b11001), Is.False); // False
```

### 4. Briefcase Lock

A briefcase has a 4-digit lock. Each digit is a number from 0 to 9 that can be rolled either forwards or backwards.
Given the current code on a briefcase and the target code to unlock it, return the minimum number of turns
necessary to unlock the briefcase.

To illustrate:
The current lock is '0230' and the target lock is '9231'. This requires one turn backward on the first tumbler (0 -> 9) and one turn forward on the fourth tumbler (0 -> 1). The minimum number of turns required is 2.

**Input constraints:** two strings of 4 digits each.

Output examples:

```csharp
    var bc = new BriefcaseLock();
    bc.TurnsRequired("0000", "0000"); // expected 0
    bc.TurnsRequired("0000", "1000"); // expected 1
    bc.TurnsRequired("0230", "9231"); // expected 2
    bc.TurnsRequired("4089", "5672"); // expected 9
```

### 5. Count the Number of Letters and Digits

Given a string, return a description the number of letters and digits in the format "LETTERS = X, DIGITS = Y".

**Input constraints:** string of length 1 .. 1000 characters.
**Output examples:**

```csharp
    var c = new CountTheLettersAndDigits();
    c.Count("Hello World!"); // expected "LETTERS = 10, DIGITS = 0"
    c.Count("Today is 2022-01-01"); // expected "LETTERS = 7, DIGITS = 8"
    c.Count("1234567890"); // expected "LETTERS = 0, DIGITS = 10"
```

Note that spaces, punctuation, and special characters are not counted as
letters or digits.

### 6. Detect a Cycle in the Graph

Determines whether the given graph has any cycles.

The method should traverse the graph and check for any circular paths,
returning `true` if a cycle is found, or `false` otherwise.
This can be achieved using depth-first search (DFS) or breadth-first search (BFS).

For example, given the following graph:

```csharp
 FromEdgeNotation(new string[] {
     "A-B",
     "B-C",
     "C-D",
     "D-A"
 })
```

The method would return `true` because there is a cycle: A → B → C → D → A.

However, if the graph was:

```csharp
 FromEdgeNotation(new string[] {
     "A-B",
     "B-C",
     "C-D"
 })
```

The method would return `false` because there are no cycles.

### 7. DigitSumCalculator

Implement a method that returns the sum of the digits of the given non-negative integer.
For example, if the input is 123, the output should be 6 (1 + 2 + 3).

```csharp
var dc = new DigitSumCalculator();
dc.AreSumOfDigits(123); // 6
dc.AreSumOfDigits(007); // 7
dc.AreSumOfDigits(10000); // 1
```

### 8. Merge 2 Sorted Lists

Given two sorted arrays/lists of numbers, return a new array/list,
which contains all the members from both inputs and is sorted respectively.

**Input constraints:** two `int[]` of variable sizes; both sorted in ascending order.  
Input array length not exceed 1024 elements.
**Output examples:**

```csharp
var lm = new ListMerger();
lm.Merge(
    new int[] { 1, 2, 3, },
    new int[] { 2, 3, 4, },
); // expected [ 1, 2, 2, 3, 3, 4 ]
```

### 9. LongestCommonSubsequence

Implement a method that finds the longest common subsequence (LCS) between two strings.
For example, given "abcde" and "ace", the output should be 3, as "ace" is the longest common subsequence.

```csharp
var calculator = new LongestCommonSubsequenceCalculator();

Assert.That(calculator.LongestCommonSubsequence("abcde", "ace"), Is.EqualTo(3));
```

### 10. MatrixRotator

Implement a method that rotates an NxN matrix by 90 degrees clockwise.

```csharp
var mr = new MatrixRotator();
var initial = new int [,] {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

var expected = new int [,] {
    { 7, 4, 1 },
    { 8, 5, 2 },
    { 9, 6, 3 }
}

Assert.That(rotator.RotateMatrix(input), Is.EqualTo(expected));
```

### 11. Return the Middle Character

Given a word, return the middle character(s).

**Input constraints:** string of length 1 .. 1000 characters (a-z, A-Z).
**Output examples:**

```csharp
    var mc = new MiddleCharacter();
    mc.GetMiddle("test"); // expected "es"
    mc.GetMiddle("testing"); // expected "t"
    mc.GetMiddle("middle"); // expected "dd"
    mc.GetMiddle("character"); // expected "a"
```

### 12. Nth Fibonacci

Given an integer n, return the nth number in the Fibonacci sequence as a string.

**Input constraints:** 0 < n <= 200.

Output examples:

```csharp
    var nf = new NthFibonacci();
    nf.Fibonacci(1); // expected "1"
    nf.Fibonacci(2); // expected "1"
    nf.Fibonacci(10); // expected "55"
```

Note that your function is expected to calculate numbers greater than UInt64.MaxValue.

### 13. Is Number a Palindrome?  

**Input constraints:** `UInt64` number (`0 .. 2^64 - 1`).  
**Output examples:**

```csharp
var np = new NumberPalyndrome();
np.IsPalyndrome(12321) == True;
np.IsPalyndrome(12320) == False;
```

### 14. Power Rangers

Given an integer n, and two integers a and b, return the number of positive
values raised to the nth power that lie in the range [a, b], inclusive.

**Input constraints:** three int values, 0 < n < 1000, 0 < a < b.
**Output examples:**

```csharp
    var pr = new PowerRanger();
    pr.CountPowers(2, 48, 65); // expected 2
    // 2 squares (n^2) lie between 48 and 65, 49 (7^2) and 64 (8^2)
    pr.CountPowers(3, 1, 27); // expected 3
    // 3 cubes (n^3) lie between 1 and 27, 1 (1^3), 8 (2^3) and 27 (3^3)
```

### 15. Reverse Polish Notation

Evaluates the value of an arithmetic expression in Reverse Polish Notation (RPN).
For example, given the tokens ["2", "1", "+", "3", "*"], the output will be 9.
Explanation: ((2 + 1) * 3) = 9.

* DivideByZeroException
Thrown when an attempt is made to divide by zero during evaluation.
For example, if the tokens contain a division operation and the second operand is zero.

* InvalidOperationException
Thrown in the following scenarios:
    1. If an operator is encountered but there are not enough operands available in the stack.
   This indicates that the expression is malformed and cannot be evaluated.
   Example: Given tokens ["2", "+"], this would throw an exception as there's only one operand.
    2. If there are extra operands left in the stack after processing all tokens,
   which indicates that there were too many operands provided for the number of operations.
   Example: Given tokens ["2", "3", "4", "+"], this would throw an exception as there are two operands remaining.
    3. If an unknown operator is encountered that is not recognized by the evaluator.
       * Example: Given tokens ["2", "3", "unknownOperator"], this would throw an exception.
       * Example: Given tokens ["a", "3", "+"], this would throw an exception.

```csharp
var evaluator = new ReversePolishNotationEvaluator();

Assert.That(evaluator.EvaluateRPN(new string[] {"2", "1", "+", "3", "*"}), Is.EqualTo(9));

Assert.Throws<InvalidOperationException>(() => evaluator.EvaluateRPN(new string[] { "2", "3", "4", "+" }));
Assert.Throws<InvalidOperationException>(() => evaluator.EvaluateRPN(new string[] { "2", "+" }));
Assert.Throws<DivideByZeroException>(() => evaluator.EvaluateRPN(new string[] { "4", "0", "/" }));
```

### 16. Simplified Fractions

Given a fraction (expressed as a string), return a simplified version of the fraction.

**Input constraints:** A string of the form "numerator/denominator" where both numerator and denominator are integers.
**Output exampless:**

```csharp
var sf = new SimplifiedFractions();
    sf. Simplify("4/ 8"); // expected "1/ 2"
    sf. Simplify("15/ 25"); // expected "3/ 5"
    sf. Simplify("4/ 2"); // expected "2"
```

Note: If improper fractions can be transformed into integers, do so in your code (e. g. "4/ 2" should return "2").

### 17. SubsequenceCalculator

Finds the length of the longest increasing subsequence in the given array.
For example: 10, 9, 2, 5, 3, 7, 101, 18 results in 4.

```csharp
var calculator = new SubsequenceCalculator();
// Where 2, (5 or 3), 7, 101 => 4
Assert.That(calculator.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }), Is.EqualTo(4));
```

### 18. SubstringFinder

Implement a method that finds the length of the longest substring without repeating characters.
For example, the longest substring without repeating characters in "abcabcbb" is "abc", which has a length of 3.

```csharp
var sf = new SubstringFinder();

Assert.That(sf.LengthOfLongestSubstring("abcabcbb"), Is.EqualTo(3)); // abc
```

### 19. Valid Parentheses

Given a string, return boolean if all the parentheses inside match general math conventions.

**Input constraints:** A string of max. 1024 ASCII chars.  
Following considered as parentheses pairs: `() [] {}`.  
**Output examples:**

```csharp
var vp = new ValidParentheses();
vp.IsValid("5 + 6 * (3 - 2 / (...))") == True;
vp.IsValid("({}[]) [{}([])]") == True;

vp.IsValid("(( [)] )") == False;
//              ^ the ] expected
vp.IsValid("(( {}[] )") == False;
//                   ^ the ) is missing
```

### 20. WordSearch

Implement a method that checks if a word exists in a 2D board of characters.
The word can be constructed from letters of sequentially adjacent cells,
where "adjacent" cells are those horizontally or vertically neighboring.

```csharp
var wordSearch = new WordSearch();
char[,] example = {
    { 'A', 'B', 'C', 'E' },
    { 'S', 'F', 'C', 'S' },
    { 'A', 'D', 'E', 'E' }
};

Assert.That(wordSearch.Exist(example, "ABCCED"), Is.True); // True
Assert.That(wordSearch.Exist(example, "ABCCEDE"), Is.False); // False
```
