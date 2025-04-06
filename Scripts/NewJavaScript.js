// Highlight rows where first name starts with "M"
window.onload = function () {
    var rows = document.querySelectorAll("#studentTable tbody tr");
    rows.forEach(function (row) {
        var firstName = row.cells[1].textContent.trim(); // Get first name from 2nd cell
        if (firstName.charAt(0).toUpperCase() === "M") {
            row.style.color = "red";
        }
    });
};