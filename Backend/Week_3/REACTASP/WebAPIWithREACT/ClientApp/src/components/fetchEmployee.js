import React, { useEffect, useState } from 'react';

const FetchEmployee = () => {
    const [employees, setEmployees] = useState([]);

    useEffect(() => {
        fetch('http://localhost:5035/api/Employees').then((res) => res.json()).then((data) => setEmployees(data)).catch(err => console.log(err))
    }, [])

    return (
        <div>
            <h2>List of Employees</h2>
            <ul>
                {employees.map(employee => {
                    return <li>{employee.name}</li>
                }) }
            </ul>

        </div>
    )
}

export default FetchEmployee;