-- Create the tables
CREATE TABLE employees (
    employee_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    department_id INT,
    salary DECIMAL(10, 2),
    created_at TIMESTAMP DEFAULT NOW(),
    updated_at TIMESTAMP DEFAULT NOW()
);

CREATE TABLE departments (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(50),
    created_at TIMESTAMP DEFAULT NOW(),
    updated_at TIMESTAMP DEFAULT NOW()
);

-- Add rows
INSERT INTO departments (department_id, department_name, created_at, updated_at)
VALUES 
(101, 'Sales', NOW(), NOW()),
(102, 'Engineering', NOW(), NOW()),
(103, 'Marketing', NOW(), NOW()),
(104, 'HR', NOW(), NOW());

INSERT INTO employees (employee_id, first_name, last_name, department_id, salary, created_at, updated_at)
VALUES 
(1, 'John', 'Doe', 101, 60000.00, NOW(), NOW()),
(2, 'Jane', 'Smith', 102, 80000.00, NOW(), NOW()),
(3, 'Emily', 'Davis', 103, 75000.00, NOW(), NOW()),
(4, 'Michael', 'Brown', 101, 65000.00, NOW(), NOW()),
(5, 'Sarah', 'Wilson', 104, 70000.00, NOW(), NOW()),
(6, 'David', 'Lee', 102, 90000.00, NOW(), NOW());

-- Alter table to add column
ALTER TABLE employees ADD COLUMN email VARCHAR(100);

-- Update the email column
UPDATE employees
SET email = 'john.doe@example.com'
WHERE employee_id = 1;

-- Delete a row
DELETE FROM employees
WHERE employee_id = 6;

-- Inner join
SELECT e.employee_id, e.first_name, e.last_name, d.department_name, e.salary, e.created_at
FROM employees e
INNER JOIN departments d ON e.department_id = d.department_id;

-- Left join
SELECT e.employee_id, e.first_name, e.last_name, d.department_name, e.created_at
FROM employees e
LEFT JOIN departments d ON e.department_id = d.department_id;

-- Right join
SELECT e.employee_id, e.first_name, e.last_name, d.department_name, e.created_at
FROM employees e
RIGHT JOIN departments d ON e.department_id = d.department_id;

-- Full join
SELECT e.employee_id, e.first_name, e.last_name, d.department_name, e.created_at
FROM employees e
FULL OUTER JOIN departments d ON e.department_id = d.department_id;

-- Subquery in a SELECT statement
SELECT employee_id, first_name, last_name, salary, created_at,
    (SELECT department_name FROM departments WHERE department_id = e.department_id) AS department_name
FROM employees e;

-- Subquery in a WHERE clause
SELECT first_name, last_name, created_at
FROM employees
WHERE department_id = (SELECT department_id FROM departments WHERE department_name = 'Sales');

-- Subquery in a FROM clause
SELECT avg_salary, created_at
FROM (SELECT AVG(salary) AS avg_salary, MAX(created_at) AS created_at FROM employees) AS avg_salary_table;

-- Use of WHERE clause
SELECT first_name, last_name, salary
FROM employees
WHERE salary > 70000;

-- Use of CASE statement
SELECT employee_id, first_name, last_name, 
       CASE 
           WHEN salary > 70000 THEN 'High Salary'
           ELSE 'Low Salary'
       END AS salary_status
FROM employees;

-- Use of ORDER BY clause
SELECT first_name, last_name, salary
FROM employees
ORDER BY salary DESC;

-- Use of GROUP BY clause
SELECT department_id, AVG(salary) AS avg_salary
FROM employees
GROUP BY department_id;

-- Use of HAVING clause
SELECT department_id, AVG(salary) AS avg_salary
FROM employees
GROUP BY department_id
HAVING AVG(salary) > 70000;
