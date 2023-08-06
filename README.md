# DVT Challenge
This is an implementation of the Elevator Challenge in C# with support for multiple floors, multiple elevators, and handling passenger interactions. The (weight limit) has also been considered in the Elevator class. You can extend and modify the code as needed to add more features and improve the efficiency of the elevator system.

The following classes have been created for Elevator, Floor, and the ElevatorController. The controller will manage multiple elevators and handle elevator movement and passenger interactions.

How SOLID and DRY principles were used in the code:

1. SOLID Principles:
   
a) Single Responsibility Principle (SRP):
The code follows the SRP by separating different responsibilities into separate classes. Each class has a specific responsibility:
- The `Elevator` class is responsible for elevator movement and handling passenger interactions within a single elevator.
- The `Floor` class is responsible for managing the state of a floor, including the number of people waiting on that floor.
- The `ElevatorController` class is responsible for managing multiple elevators, coordinating their movements, and handling passenger interactions at a higher level.

b) Open/Closed Principle (OCP):
The code shows a degree of flexibility and extensibility, making it easier to extend the behavior of individual classes without modifying their existing code. For instance, you can add new features to the `Elevator` class or extend the `ElevatorController` to support additional functionalities without changing their core implementations.

2. DRY Principle (Don't Repeat Yourself):
The code demonstrates adherence to the DRY principle by avoiding duplication of code and promoting reusability:

- The elevator movement logic (e.g., moving to a target floor) is encapsulated within the `Elevator` class. This logic is not duplicated in other parts of the codebase.
- The logic to manage the number of people waiting on a floor and inside an elevator is encapsulated within the respective classes (`Floor` and `Elevator`).

By adhering to SOLID principles, the code is designed to be more maintainable, extensible, and easier to understand. The DRY principle ensures that code is concise, efficient, and easier to modify without the risk of introducing bugs due to code duplication.
