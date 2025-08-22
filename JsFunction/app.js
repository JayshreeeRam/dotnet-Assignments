function countDigits() {
      let num = document.getElementById("num").value;
      let result = document.getElementById("result");

      if (num === "") {
        result.innerHTML = "Please enter a valid number.";
        return;
      }

      let even = 0, odd = 0, zero = 0;

      for (let digit of num) {
        let d = parseInt(digit);
        if (d === 0) {
          zero++;
        } else if (d % 2 === 0) {
          even++;
        } else {
          odd++;
        }
      }

      result.innerHTML = 
        "Even digits: " + even + "<br>" +
        "Odd digits: " + odd + "<br>" +
        "Zeros: " + zero;
    }

countDigits();