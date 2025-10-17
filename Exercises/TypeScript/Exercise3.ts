import * as readline from "readline";

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question("Enter a number: ", (answer) => {
  const n = parseInt(answer);

  let result = "";
  for (let i = 1; i <= n; i++) {
    if (i % 3 === 0 && i % 5 === 0) {
      result += "FizzBuzz ";
    } else if (i % 3 === 0) {
      result += "Fizz ";
    } else if (i % 5 === 0) {
      result += "Buzz ";
    } else {
      result += i + " ";
    }
  }
  console.log(result.trim());
  rl.close();
});
