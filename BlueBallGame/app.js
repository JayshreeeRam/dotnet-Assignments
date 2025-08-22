const randomNum = Math.floor(Math.random() * 10) + 1;
console.log("Random number is:", randomNum); 
let maxTries = 5;
let triesLeft = maxTries;

const range = document.getElementById("circleRange");
const statusText = document.getElementById("status");
const playAgainBtn = document.getElementById("playAgain");

statusText.textContent = `You have ${triesLeft} tries left`;

range.addEventListener("input", function () {
    if (triesLeft <= 0) {
        alert("Game over! Out of tries.");
        return;
    }
    const guess = parseInt(this.value);

    if (guess < randomNum) {
        document.getElementById("circle-" + guess).style.background = "yellow";
    } else if (guess === randomNum) {
       document.getElementById("circle-" + guess).style.background = "green";
        statusText.textContent = `🎉 You won in ${maxTries - triesLeft + 1} tries!`;
        return;
    } else {
        document.getElementById("circle-" + guess).style.background = "red";
    }
    triesLeft--;
    console.log("Tries left:", triesLeft);
    if (triesLeft > 0) {
        statusText.textContent = `Wrong guess. ${triesLeft} tries left.`;
    } else {
        statusText.textContent = `No tries left! The number was ${randomNum}`;
        range.disabled = true;
    }
});

