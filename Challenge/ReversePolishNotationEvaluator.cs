namespace Challenge
{
    public class ReversePolishNotationEvaluator
    {
        /// <summary>
        /// Evaluates the value of an arithmetic expression in Reverse Polish Notation (RPN).
        /// For example, given the tokens ["2", "1", "+", "3", "*"], the output will be 9.
        /// Explanation: ((2 + 1) * 3) = 9.
        /// </summary>
        /// <param name="tokens">An array of tokens representing the expression in Reverse Polish Notation.</param>
        /// <returns>The result of the evaluated expression.</returns>
        /// <exception cref="DivideByZeroException">
        /// Thrown when an attempt is made to divide by zero during evaluation.
        /// For example, if the tokens contain a division operation and the second operand is zero.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown in the following scenarios:
        /// 1. If an operator is encountered but there are not enough operands available in the stack.
        ///    This indicates that the expression is malformed and cannot be evaluated.
        ///    Example: Given tokens ["2", "+"], this would throw an exception as there's only one operand.
        /// 2. If there are extra operands left in the stack after processing all tokens,
        ///    which indicates that there were too many operands provided for the number of operations.
        ///    Example: Given tokens ["2", "3", "4", "+"], this would throw an exception as there are two operands remaining.
        /// 3. If an unknown operator is encountered that is not recognized by the evaluator.
        ///    Example: Given tokens ["2", "3", "unknownOperator"], this would throw an exception.
        ///    Example: Given tokens ["a", "3", "+"], this would throw an exception.
        /// </exception>
        public int EvaluateRPN(string[] tokens)
        {
            throw new NotImplementedException();
        }
    }
}
