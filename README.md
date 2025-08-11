# TacoTales Restaurant Management System

A comprehensive ASP.NET Core MVC web application for managing a restaurant's menu, ingredients, orders, and customer interactions.

## 🌮 Features

### Core Functionality
- **Menu Management**: Create, edit, and delete menu items with images
- **Ingredient Tracking**: Manage ingredients and their associations with products
- **Order System**: Complete ordering workflow with shopping cart functionality
- **User Authentication**: Secure login/registration system using ASP.NET Identity
- **Category Management**: Organize menu items by categories (Appetizer, Entree, Side Dish, Dessert, Beverage)

### Key Capabilities
- **Product-Ingredient Relationships**: Many-to-many relationships between products and ingredients
- **Session-Based Shopping Cart**: Persistent cart across user sessions
- **Order History**: Users can view their previous orders
- **Image Upload**: Support for product images with file handling
- **Responsive Design**: Bootstrap-powered responsive UI

## 🛠 Technology Stack

- **Framework**: ASP.NET Core 9.0 MVC
- **Database**: SQL Server with Entity Framework Core
- **Authentication**: ASP.NET Core Identity
- **Frontend**: Bootstrap 5, jQuery, HTML5/CSS3
- **Architecture**: Repository Pattern with Generic Repository
- **Session Management**: In-memory session storage

## 📁 Project Structure

```
FoodResturant/
├── Controllers/           # MVC Controllers
│   ├── HomeController.cs
│   ├── IngredientController.cs
│   ├── OrderController.cs
│   └── ProductController.cs
├── Data/
│   └── ApplicationDbContext.cs  # Database context and configuration
├── Models/               # Domain models and ViewModels
│   ├── Product.cs
│   ├── Order.cs
│   ├── Ingredient.cs
│   ├── Category.cs
│   ├── Repository.cs     # Generic repository implementation
│   └── ViewModels/
├── Views/               # Razor views
│   ├── Home/
│   ├── Product/
│   ├── Order/
│   ├── Ingredient/
│   └── Shared/
└── wwwroot/            # Static files
    └── images/         # Product images
```

## 🗃 Database Schema

### Core Entities
- **Products**: Menu items with name, description, price, stock, and category
- **Categories**: Menu categories (Appetizer, Entree, etc.)
- **Ingredients**: Individual ingredients used in products
- **Orders**: Customer orders with date and total amount
- **OrderItems**: Line items within orders
- **ProductIngredients**: Many-to-many junction table

### Seeded Data
The application includes seed data for:
- 5 Categories (Appetizer, Entree, Side Dish, Dessert, Beverage)
- 6 Ingredients (Beef, Chicken, Fish, Tortilla, Lettuce, Tomato)
- 3 Products (Beef Taco, Chicken Taco, Fish Taco)

## 🔧 Key Features Explained

### Repository Pattern
The application uses a generic repository pattern (`Repository<T>`) that provides:
- Async CRUD operations
- Flexible querying with `QueryOptions<T>`
- Include functionality for related data
- Dynamic property-based filtering

### Session Management
Shopping cart functionality uses custom session extensions (`SessionExtensions`) for:
- JSON serialization/deserialization
- Type-safe session storage
- Cart persistence across requests

### Image Handling
Product images are handled through:
- File upload via `IFormFile`
- Unique filename generation
- Storage in `wwwroot/images/`
- Fallback to placeholder images

### Security Features
- ASP.NET Core Identity integration
- Anti-forgery token validation
- Authorized controller actions
- User-specific order isolation

## 🎯 Default Route

The application is configured with a custom default route:
```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ingredient}/{action=Index}/{id?}")
```

This means the application starts at the Ingredients page by default.

## 🔍 API Endpoints

### Ingredients
- `GET /Ingredient` - List all ingredients
- `GET /Ingredient/Create` - Create ingredient form
- `POST /Ingredient/Create` - Submit new ingredient
- `GET /Ingredient/Edit/{id}` - Edit ingredient form
- `POST /Ingredient/Edit` - Update ingredient
- `GET /Ingredient/Delete/{id}` - Delete confirmation
- `POST /Ingredient/Delete` - Delete ingredient

### Products
- `GET /Product` - List all products
- `GET /Product/AddEdit/{id?}` - Add/Edit product form
- `POST /Product/AddEdit` - Submit product changes
- `POST /Product/Delete/{id}` - Delete product

### Orders
- `GET /Order/Create` - Product selection page
- `POST /Order/AddItem` - Add item to cart
- `GET /Order/Cart` - View shopping cart
- `POST /Order/PlaceOrder` - Submit order
- `GET /Order/ViewOrders` - User order history


## 🚀 Future Enhancements

- [ ] Add payment processing integration
- [ ] Implement real-time order tracking
- [ ] Add admin dashboard for analytics
- [ ] Mobile app integration
- [ ] Advanced inventory management
- [ ] Customer loyalty program
- [ ] Multi-location support
