var StudentManagingSystem = (function () {
    function addStudent (url, studentName, studentGrade) {
        $.ajax({
            url: url,
            type: 'POST',
            timeout: 1000,
            data: { name: studentName, grade: studentGrade }
        });
    };

    function showAllStudents (url) {
        $.ajax({
            url: url,
            type: 'GET',
            timeout: 1000,
            success: function (data) {
                console.log(data);
            }
        });
    };

    { _method: 'delete' }

    function deleteStudent(url, id) {
        $.ajax({
            url: url + id,
            type: 'POST',
            timeout: 1000,
            data: { _method: 'delete' }
        });
    };

    return {
        addStudent: addStudent,
        showAllStudents: showAllStudents,
        deleteStudent: deleteStudent
    }
})();