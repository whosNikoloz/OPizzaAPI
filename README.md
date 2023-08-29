# PizzaAPI - C# API Repository

Welcome to the Pizza Ordering API repository! This API is designed to manage pizza orders, providing endpoints for retrieving pizza information and saving orders.

## Endpoints

### 1. Retrieve Pizza List
- **Endpoint:** `https://localhost:7106/api/Pizza`
- **Method:** GET
- **Description:** Fetch a list of available pizzas.

### 2. Retrieve Pizza by ID
- **Endpoint:** `http://localhost:5132/api/Pizza/?id=1`
- **Method:** GET
- **Description:** Retrieve details about a specific pizza using its ID.

### 3. Save Pizza Order
- **Endpoint:** `http://localhost:5132/api/Pizza/`
- **Method:** POST
- **Description:** Place a new pizza order by sending order details in the request body.

### 4. Retrieve Pizza by ID (Alternate)
- **Endpoint:** `https://localhost:7106/api/Pizza?id=1`
- **Method:** GET
- **Description:** An alternate endpoint to retrieve pizza details using its ID.

## Getting Started

Follow these steps to set up the API on your local machine:

1. **Clone the repository:**

   ```bash
   git clone https://github.com/whosNikoloz/OPizzaAPI.git

Open the project:

Open the project in your preferred C# IDE.

Configure the API:

Configure API settings, database connections, and necessary environment variables.

Build and Run:

Build and run the API project.

Access Endpoints:

Access the endpoints using the provided URLs, e.g., https://localhost:7106/api/Pizza.

Contributing
We encourage contributions to enhance the Pizza Ordering API. To contribute:

Fork the repository.

Create a branch:

bash
Copy code
git checkout -b feature/new-feature
Make changes:

Implement your changes and commit them with clear messages:

bash
Copy code
git commit -m "Add new feature"
Push your changes:

bash
Copy code
git push origin feature/new-feature
Create a Pull Request:

Open a Pull Request to merge your changes into the main branch.

Feel free to explore and improve the API. Happy coding!
