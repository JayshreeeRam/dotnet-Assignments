function isPrime(num) {
      if (num <= 1) return false; 
      if (num === 2) return true; 
      if (num % 2 === 0) return false;

      for (let i = 3; i <= Math.sqrt(num); i += 2) {
        if (num % i === 0) return false;
      }
      return true;
    }

    function checkPrime() {
      let number = parseInt(document.getElementById("num").value);
      let result = document.getElementById("result");

      if (isNaN(number)) {
        result.innerHTML = "Please enter a valid number.";
        return;
      }

      if (isPrime(number)) {
        result.innerHTML = number + " is a Prime number";
      } else {
        result.innerHTML = number + " is NOT a Prime number";
      }
    }

    checkPrime();