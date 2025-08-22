// Handle Registration
document.addEventListener("DOMContentLoaded", () => {
  const registerForm = document.getElementById("registerForm");
  const loginForm = document.getElementById("loginForm");
  const timesheetForm = document.getElementById("timesheetForm");

  // Registration
  if (registerForm) {
    registerForm.addEventListener("submit", e => {
      e.preventDefault();
      const name = document.getElementById("regName").value;
      const email = document.getElementById("regEmail").value;
      const password = document.getElementById("regPassword").value;

      localStorage.setItem("user", JSON.stringify({ name, email, password }));
      alert("Registration successful! Please login.");
      window.location.href = "index.html";
    });
  }

  // Login
  if (loginForm) {
    loginForm.addEventListener("submit", e => {
      e.preventDefault();
      const email = document.getElementById("loginEmail").value;
      const password = document.getElementById("loginPassword").value;
      const user = JSON.parse(localStorage.getItem("user"));

      if (user && user.email === email && user.password === password) {
        localStorage.setItem("loggedIn", "true");
        window.location.href = "timesheet.html";
      } else {
        alert("Invalid email or password!");
      }
    });
  }

  // Timesheet CRUD
  if (timesheetForm) {
    if (localStorage.getItem("loggedIn") !== "true") {
      window.location.href = "index.html";
    }

    const taskTable = document.getElementById("taskTable");
    let tasks = JSON.parse(localStorage.getItem("tasks")) || [];

    function renderTasks() {
      taskTable.innerHTML = "";
      tasks.forEach((task, index) => {
        const row = document.createElement("tr");
        row.innerHTML = `
          <td>${task.name}</td>
          <td>${task.desc}</td>
          <td>${task.date}</td>
          <td class="actions">
            <button onclick="editTask(${index})">Edit</button>
            <button onclick="deleteTask(${index})">Delete</button>
          </td>
        `;
        taskTable.appendChild(row);
      });
    }

    timesheetForm.addEventListener("submit", e => {
      e.preventDefault();
      const taskName = document.getElementById("taskName").value;
      const taskDesc = document.getElementById("taskDesc").value;
      const taskDate = document.getElementById("taskDate").value;

      tasks.push({ name: taskName, desc: taskDesc, date: taskDate });
      localStorage.setItem("tasks", JSON.stringify(tasks));
      renderTasks();
      timesheetForm.reset();
    });

    window.editTask = index => {
      const task = tasks[index];
      document.getElementById("taskName").value = task.name;
      document.getElementById("taskDesc").value = task.desc;
      document.getElementById("taskDate").value = task.date;

      tasks.splice(index, 1);
      localStorage.setItem("tasks", JSON.stringify(tasks));
      renderTasks();
    };

    window.deleteTask = index => {
      tasks.splice(index, 1);
      localStorage.setItem("tasks", JSON.stringify(tasks));
      renderTasks();
    };

    renderTasks();
  }
});

// Logout function
function logout() {
  localStorage.removeItem("loggedIn");
  window.location.href = "index.html";
}
