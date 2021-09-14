function buttonClick() {
    //alert('You clicked the button');
    //var num = 10;
    //num = num + "10";
    //alert(num);

    var name = document.getElementById("txtName");
    var div = document.getElementById("spanMessage");
    console.log(name.value);
    var gender = document.getElementById("rdbMale").checked ? "Mr. " : "Ms. "
    if (name.value == "") {
        //alert("Name cannot be empty");
        // name.focus();
        div.innerHTML = "Name cannot be empty";
        name.style.borderColor = "Red";
        div.classList.add("alert-danger");
    }
    else {
        div.innerHTML = "Hello " + gender + name.value;
        div.classList.remove("alert-danger")
        div.classList.add("alert-success");
    }

    //alert("Hello "+gender + name.value);

}
function sampleArray() {
    var arr = ["Car", "Bike", "Ship", "Boat"];
    arr[5] = "Done";

    for (var i = 0; i < arr.length; i++) {
        console.log(arr[i]);
    }
}
function sampleObject() {
    var employee = {
        "id": 101,
        "name": "Tim",
        "age":21
    }
    employee.salary = 12344.43;
    console.log("Employee name : " + employee.name)
    console.log("Employee salary : " + employee.salary)
}
function objectArray() {
    var employees = [
        {
            "id": 101,
            "name": "Tim",
            "age": 21
        },
        {
            "id": 102,
            "name": "Jim",
            "age": 32
        }
    ];
    var myTable = document.getElementById("empTable");
    for (var i = 0; i < employees.length; i++) {
        var tr = myTable.insertRow(i+1);
        var id = tr.insertCell(0);
        id.innerHTML = employees[i].id;
        var name = tr.insertCell(1);
        name.innerHTML = employees[i].name;
        var age = tr.insertCell(2);
        age.innerHTML = employees[i].age;
    }
}