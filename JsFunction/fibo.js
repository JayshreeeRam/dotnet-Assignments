function findFibonacciSum() {
      let n = parseInt(document.getElementById("n").value);
      let result = document.getElementById("result");

      if (isNaN(n) || n <= 0) {
        result.innerHTML = "Please enter a valid positive number.";
        return;
      }

      let a = 0, b = 1, sum = 0;

      for (let i = 1; i <= n; i++) {
        sum += a;
        let next = a + b;
        a = b;
        b = next;
      }

      result.innerHTML = "Sum of first " + n + " Fibonacci numbers = " + sum;
    }

    findFibonacciSum();