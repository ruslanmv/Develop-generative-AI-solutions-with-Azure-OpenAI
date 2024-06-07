def findDifferenceCheckFibonacci (num1, num2):
    diff = abs(num1 - num2)
    if is_fibonacci(diff):
        return f"The difference ({diff}) is in the Fibonacci sequence." 
    else:  
        return f"The difference ({diff}) is not in the Fibonacci sequence." 