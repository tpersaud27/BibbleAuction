# Project Overview

## Technologies Used

This project leverages a modern stack for building, deploying, and scaling the auction platform:

- **.NET** – Backend services and Entity Framework Core for data access  
- **Next.js** – Frontend framework for server-side rendering and React-based UI  
- **RabbitMQ** – Message broker for reliable event-driven communication  
- **Kubernetes** – Container orchestration for scaling and managing services  
- **Docker** – Containerization for consistent builds and deployments  
- **SignalR** – Real-time communication for live auction updates  
- **IdentityServer** – Authentication and authorization with secure token service  

## Auction Service Entities

- Represents a table inside a database  
- Each of the entity properties represents a column

### Auction

Represents the auction details for a specific item.  

- **Id** (`Guid`)  
  Default primary key for the table in Entity Framework.  

- **ReservePrice** (`int`, default = 0)  
  Minimum price required for the item to be sold.  

- **Seller** (`string`)  
  Identifier or name of the seller.  

- **Winner** (`string`)  
  Identifier or name of the winning bidder (if auction is completed).  

- **SoldAmount** (`int?`)  
  Final amount the item was sold for (nullable if not sold).  

- **CurrentHighBid** (`int?`)  
  Current highest bid amount during the auction (nullable if no bids).  

- **CreatedAt** (`DateTime`, default = `UtcNow`)  
  Timestamp when the auction was created.  

- **UpdatedAt** (`DateTime`, default = `UtcNow`)  
  Timestamp when the auction was last updated.  

- **Status** (`Status`)  
  Current status of the auction (`Live`, `Finished`, `ReserveNotMet`).  

- **Item** (`Item`)  
  Navigation property linking to the associated `Item`.  

---

### Item

Represents an item (e.g., a car) listed in an auction.

- **Id** (`Guid`)  
  Unique identifier for the item.  

- **Make** (`string`)  
  Manufacturer of the item.  

- **Model** (`string`)  
  Specific model name of the item.  

- **Year** (`int`)  
  Year the item was manufactured.  

- **Color** (`string`)  
  Color of the item.  

- **Mileage** (`int`)  
  Total miles the item has been driven.  

- **ImageUrl** (`string`)  
  URL of an image representing the item.  

- **Auction** (`Auction`)  
  Navigation property for Entity Framework (establishes a 1-to-1 relationship with `Auction`).  

- **AuctionId** (`Guid`)  
  Foreign key reference to the related auction.  

---

### Status

Represents the state of an auction.  

- **Live**  
  Auction is active and bids can be placed.  

- **Finished**  
  Auction has ended successfully.  

- **ReserveNotMet**  
  Auction ended but the reserve price was not met, so the item is unsold.  
