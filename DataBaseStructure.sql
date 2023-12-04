
1. Workers:
   - WorkerID (Primary Key)
   - FirstName
   - LastName
   - Address1
   - WorkerType

2. HourlyWorkers:
   - WorkerID (Primary Key, Foreign Key referencing Workers)
   - PayPerHour

3. SalariedWorkers:
   - WorkerID (Primary Key, Foreign Key referencing Workers)
   - AnnualSalary

4. ManagerDetails:
   - WorkerID (Primary Key, Foreign Key referencing Workers)
   - MaxExpenseAmount
