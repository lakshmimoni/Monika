# 3D Cube with Z-Lock

## Overview

This project is a full-stack web application that demonstrates a 3D cube with realistic shadows and a Z-Lock feature. The application is built using React.js for the frontend, Three.js for 3D graphics, and C# with SQLite for the backend.

## Setup

### Backend
1. Open the C# project in Visual Studio.
2. Run `Update-Database` to apply migrations and create the SQLite database.
3. Start the backend server.

### Frontend
1. Navigate to the React project directory.
2. Run `npm install` to install dependencies.
3. Run `npm start` to start the frontend development server.

## Features

- 3D cube with realistic shadows
- Z-Lock feature to lock rotation along the Z-axis
- CRUD operations for cube data stored in SQLite

## API Endpoints

- `GET /api/cubecases` - Retrieve all cube cases
- `POST /api/cubecases` - Create a new cube case
- `PUT /api/cubecases/{id}` - Update an existing cube case
- `DELETE /api/cubecases/{id}` - Delete a cube case

## Additional Information

For more details, refer to the code comments and documentation within the project.
