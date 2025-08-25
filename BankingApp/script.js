class Person {
  constructor(name) {
    this.name = name;
  }
}

class Account {
  constructor(owner, balance = 0) {
    this.owner = owner;
    this.balance = balance;
    this.accountNumber = Math.floor(Math.random() * 1000000);
  }

  deposit(amount) {
    if (amount <= 0) return alert("Enter a valid amount");
    this.balance += amount;
  }

  withdraw(amount) {
    if (amount <= 0) return alert("Enter a valid amount");
    if (this.balance < amount) return alert("Insufficient balance");
    this.balance -= amount;
  }

  transfer(targetAccount, amount) {
    if (this.balance < amount) return alert("Insufficient balance for transfer");
    this.withdraw(amount);
    targetAccount.deposit(amount);
  }
}

let accounts = [];

// Utility to refresh account dropdowns and list
function updateUI() {
  const selectAccount = document.getElementById("selectAccount");
  const fromAccount = document.getElementById("fromAccount");
  const toAccount = document.getElementById("toAccount");
  const accountsList = document.getElementById("accountsList");

  selectAccount.innerHTML = "";
  fromAccount.innerHTML = "";
  toAccount.innerHTML = "";
  accountsList.innerHTML = "";

  accounts.forEach((acc, index) => {
    const option = `<option value="${index}">${acc.owner.name} (Acc#: ${acc.accountNumber})</option>`;
    selectAccount.innerHTML += option;
    fromAccount.innerHTML += option;
    toAccount.innerHTML += option;

    accountsList.innerHTML += `<p><strong>${acc.owner.name}</strong> | Account: ${acc.accountNumber} | Balance: ₹${acc.balance}</p>`;
  });
}

// Create Account
function createAccount() {
  const name = document.getElementById("personName").value;
  const deposit = parseFloat(document.getElementById("initialDeposit").value);
  if (!name || isNaN(deposit) || deposit < 0) return alert("Enter valid details!");

  const person = new Person(name);
  const account = new Account(person, deposit);
  accounts.push(account);

  updateUI();
  alert(`Account created for ${name} with ₹${deposit}`);
}

// Deposit
function deposit() {
  const index = document.getElementById("selectAccount").value;
  const amount = parseFloat(document.getElementById("amount").value);
  if (index === "" || isNaN(amount)) return alert("Select account and enter valid amount!");

  accounts[index].deposit(amount);
  updateUI();
}

// Withdraw
function withdraw() {
  const index = document.getElementById("selectAccount").value;
  const amount = parseFloat(document.getElementById("amount").value);
  if (index === "" || isNaN(amount)) return alert("Select account and enter valid amount!");

  accounts[index].withdraw(amount);
  updateUI();
}

// Transfer
function transfer() {
  const fromIndex = document.getElementById("fromAccount").value;
  const toIndex = document.getElementById("toAccount").value;
  const amount = parseFloat(document.getElementById("transferAmount").value);

  if (fromIndex === toIndex) return alert("Cannot transfer to the same account!");
  if (fromIndex === "" || toIndex === "" || isNaN(amount)) return alert("Select valid accounts and enter amount!");

  accounts[fromIndex].transfer(accounts[toIndex], amount);
  updateUI();
}

updateUI();
