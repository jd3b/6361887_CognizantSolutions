# Understanding Recursion and Analysis

## 1. Understanding Recursion

Recursion is a programming technique where a function solves a problem by calling itself. It simplifies problems by breaking them into smaller subproblems, each of which is similar to the original.

### How Recursion Works
1. **Base Case**: The condition under which the recursion stops. Without this, the function would call itself indefinitely, leading to a stack overflow.
2. **Recursive Case**: The part of the function that reduces the problem size, eventually reaching the base case.

### Examples of Recursive Problems
- **Factorial Calculation**: 
  \[
  n! = n \times (n - 1)!
  \]
- **Fibonacci Sequence**:
  \[
  F(n) = F(n-1) + F(n-2), \quad \text{with base cases } F(0) = 0 \text{ and } F(1) = 1
  \]

### Challenges of Recursion
1. **Performance**: Repeatedly solving the same subproblems can lead to inefficiency.
2. **Memory Usage**: Each recursive call adds a frame to the call stack, which can result in stack overflow for large inputs.

### Optimization Techniques
- **Memoization**: Store results of subproblems to avoid recalculating them.
- **Tail Recursion**: Transform the recursion so that the recursive call is the last operation, allowing compilers or interpreters to optimize it.

---

## 4. Analysis

### Time Complexity
- **Pure Recursion**: \( O(n) \) – Each year requires one recursive call.
- **Memoized Recursion**: \( O(n) \) – Each subproblem is solved only once.
- **Iterative Approach**: \( O(n) \) – A loop runs for \( n \) iterations.

### Space Complexity
- **Pure Recursion**: \( O(n) \) – Due to the stack frames for each recursive call.
- **Memoized Recursion**: \( O(n) \) – For storing results in a memoization table or array.
- **Iterative Approach**: \( O(1) \) – Only a few variables are used for calculations.

### Comparison Table

| Approach               | Time Complexity | Space Complexity | Notes                                       |
|-------------------------|-----------------|------------------|---------------------------------------------|
| **Pure Recursion**      | \( O(n) \)      | \( O(n) \)       | Simple but can lead to stack overflow.      |
| **Memoized Recursion**  | \( O(n) \)      | \( O(n) \)       | Optimized for repeated subproblem solving.  |
| **Iterative Approach**  | \( O(n) \)      | \( O(1) \)       | Best for performance and memory efficiency. |

---

### Conclusion
- Recursion simplifies problem-solving but is not always efficient.
- For real-world applications, consider using an **iterative approach** or **memoization** for better performance.
