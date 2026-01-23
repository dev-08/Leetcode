# Write your MySQL query statement below


SELECT e.name As Employee FROM Employee e LEFT  JOIN Employee em ON e.managerId = em.id where e.salary > em.salary