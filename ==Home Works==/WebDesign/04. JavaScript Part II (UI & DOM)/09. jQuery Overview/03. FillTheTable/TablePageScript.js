var students = [["Aleksandar", "Krustev", 5], ["Kiril", "Metodiev", 9], ["Irena", "Ivanova", 2]];

function generateTable() {
    if ($('#studentsTable').length == 0) {
        $('body').append('<table id=studentsTable><tr><th>First Name</th><th>Last Name</th><th>Grade</th></tr></table>');

        for (var i = 0; i < students.length; i++) {
            $('#studentsTable').append('<tr><td>' + students[i][0] +
                        '</td><td>' + students[i][1] +
                        '</td><td>' + students[i][2] +
                        '</td></tr>');
        }
    }
}

$('#generatorButton').on("click", generateTable);