# 🏨 Hotelier
## Hotel Management & Online Reservation System


<img width="440" height="316" alt="architecture" src="https://github.com/user-attachments/assets/b212f532-230c-47c4-abee-3434c52e2e3a" />
<img width="601" height="641" alt="1_sXsYNOgn68nbpA9KQbxXPQ" src="https://github.com/user-attachments/assets/485f4da1-f2e7-4f25-9c38-525f8fdb50dd" />
<img width="500" height="500" alt="1_sura91gPMoCjPNvZWsAO_g" src="https://github.com/user-attachments/assets/7343aa9b-62a8-4cd4-96c7-aa32b51537f6" />

# ASP.NET Core (.NET 6) Web API & MVC | N-Layer Architecture | Identity | JWT | RapidAPI

**Hotelier** is an **enterprise-level, modular, and scalable hotel management and online reservation system** developed with **ASP.NET Core (.NET 6).**

The project follows **Clean Architecture** and **N-Layer Architecture** principles.
Business logic is exposed through a **RESTful Web API**, while the **ASP.NET Core MVC WebUI consumes the API** to render both the public website and the admin panel.

# 🎓 Training & Mentorship

*This project was developed within* ***M&Y Yazılım Eğitim Akademisi Danışmanlık***
under the mentorship of ***Murat Yücedağ.***

# 🎯 Project Goals

Apply real-world **ASP.NET Core enterprise architecture**

Demonstrate **API-driven UI** approach

Build a system where **Admin Panel, Public Website, and REST API** work together

Provide a **job-ready, portfolio-grade** project

# 🧱 Architecture Overview (Clean Architecture

![CleanArchitecture](https://github.com/user-attachments/assets/206aab73-e132-47c8-b1b0-9a4b54e2b06d)
<img width="1375" height="753" alt="image5-9 (1)" src="https://github.com/user-attachments/assets/cfe7336d-baf4-4a28-971f-f021b219afbb" />
<img width="601" height="641" alt="1_sXsYNOgn68nbpA9KQbxXPQ (1)" src="https://github.com/user-attachments/assets/4cbfdcf9-8037-49b6-9168-a335babcd8ef" />


**Layihə aşağıdakı qatlara bölünmüşdür:**

Entity Layer        → Domen modelləri
DTO Layer           → Məlumat ötürülməsi üçün DTO-lar
Data Access Layer   → EF Core, Repository Pattern
Business Layer      → Servislər və biznes qaydaları
API Layer           → RESTful Web API
WebUI               → MVC Admin Panel & Public Website

# 🏗️ Solution Structure


<img width="298" height="149" alt="Screenshot 2026-02-02 214832" src="https://github.com/user-attachments/assets/9769c5cb-f9d5-4ffd-8827-6b80842e9872" />

ApiConsume
 ├── EntityLayer
 ├── DtoLayer
 ├── DataAccessLayer
 ├── BusinessLayer
 └── HotelierAPI (ASP.NET Core Web API)

Frontend
 └── Hotelier.Api.WebUI (ASP.NET Core MVC)

JwtProject
 └── WebApiJwt (JWT Authentication)

RapidAPI
 └── RapidAPI.Consume (External API integrations)
 

# 🧠 Business Layer (Service–Manager Pattern)

![soa-design-pattern-wcf](https://github.com/user-attachments/assets/1fcec2bf-e356-45ca-996f-e07f0f8b9f5f)

![https___dev-to-uploads s3 amazonaws com_uploads_articles_0bden3ycqr271bwpvpq6](https://github.com/user-attachments/assets/bbdfd241-73d4-46f7-a7e7-81ee62fbfa16)

![0_zScVClCCjn6jHSSC](https://github.com/user-attachments/assets/9a45e812-72ee-4ac5-a7d1-84c0e04688f1)



The **Business Layer** contains all application logic and coordinates communication between controllers and the Data Access Layer.

## Core Principles

Interface-based services

Manager implementations

No business logic inside controllers

Fully Dependency Injection driven design

## Generic Service Structure

Create

Update

Delete

GetById

GetAll

## Custom Business Operations

Booking status workflow (Approve / Cancel / Wait)

Dashboard statistics

Latest records (last 4 staff, last 6 bookings)

User–WorkLocation relationships

# 🗄️ Data Access Layer (EF Core + Repository)

<img width="635" height="615" alt="0_VWgQnOkoRXkPIGKb" src="https://github.com/user-attachments/assets/8e1cfc98-cc8c-4dac-a9fe-5bac9406ae7e" />
<img width="635" height="615" alt="0_NwpsGdbEeEA72KgP" src="https://github.com/user-attachments/assets/2320de0c-d1e0-4ecc-b489-fd6e00edbdd8" />



**IGenericDal<T>** – reusable CRUD operations

**GenericRepository<T>** – EF Core-based implementation

Entity-specific repositories for advanced queries

Counts

Status updates

Custom filters

# 🧬 Identity & Database
IdentityDbContext<AppUser, AppRole, int>

**Capabilities**

ASP.NET Core Identity

Role-based authorization

User → WorkLocation relationships

Custom user fields (City, Country, Gender, etc.)

# 🔌 API Layer (ASP.NET Core Web API)
# Key Features

RESTful CRUD endpoints

Thin controller approach

AutoMapper integration

Dashboard widget endpoints

File & image upload support

# File & Image Upload

POST /api/FileImage → /images

POST /api/FileProcess → /files

# 🖥️ WebUI (ASP.NET Core MVC)
# Public Website

Home

Rooms

Booking

Contact

Subscribe

# Admin Panel

Dashboard (widget-lər)

Booking lifecycle

CRUD modulları

Inbox / Sendbox

File & image upload

# 🔐 Authentication & Authorization
## WebUI

ASP.NET Core Identity

Cookie Authentication

Role-based access

# JWT (Web API)

Separate JWT authentication project

Role-based token generation

Short-lived tokens for security testing

# 🌐 RapidAPI Integrations

Booking.com (hotel search)

Exchange Rates

IMDb Top Movies

Social media statistics



⚠️ API key-lər Environment Variables / User Secrets ilə saxlanmalıdır.

# ⚙️ Technologies Used

ASP.NET Core (.NET 6)

ASP.NET Core Web API

ASP.NET Core MVC

Entity Framework Core

SQL Server

ASP.NET Core Identity

JWT Authentication

AutoMapper

FluentValidation

MailKit

RapidAPI

Bootstrap

## 🖼️ Images

<img width="1653" height="909" alt="Screenshot 2026-02-02 223614" src="https://github.com/user-attachments/assets/f2783396-ef0a-4892-8d04-962b4621b15b" />

<img width="1645" height="892" alt="Screenshot 2026-02-02 223724" src="https://github.com/user-attachments/assets/af4c5f89-46d2-4a23-ab44-a65e436f904b" />

<img width="1639" height="844" alt="Screenshot 2026-02-02 223829" src="https://github.com/user-attachments/assets/dac879af-634e-41b9-a73d-5eb60f92b89d" />

<img width="1544" height="588" alt="Screenshot 2026-02-02 223925" src="https://github.com/user-attachments/assets/c4ae1ebc-3eed-45ce-9887-0d0ac0e84438" />

<img width="1634" height="580" alt="Screenshot 2026-02-02 224051" src="https://github.com/user-attachments/assets/061d14b7-8d1f-4c43-8e47-27426e795845" />

<img width="1648" height="456" alt="Screenshot 2026-02-02 224143" src="https://github.com/user-attachments/assets/5bf1d149-26ae-4cbc-acb2-026eb11c8f3a" />

<img width="1645" height="518" alt="Screenshot 2026-02-02 224236" src="https://github.com/user-attachments/assets/eca55496-7f77-4282-a9d5-aa93002f809b" />

<img width="1652" height="876" alt="Screenshot 2026-02-02 224329" src="https://github.com/user-attachments/assets/7693448d-f6eb-4d48-a0b6-20dd6bdf69c0" />

<img width="1653" height="881" alt="Screenshot 2026-02-02 224428" src="https://github.com/user-attachments/assets/c56fa13f-03a2-426d-9d20-d2306e71ee7f" />

<img width="1639" height="866" alt="Screenshot 2026-02-02 224513" src="https://github.com/user-attachments/assets/4e82e957-64b7-4560-8385-829b29f3e21e" />

<img width="676" height="540" alt="image" src="https://github.com/user-attachments/assets/f8389f26-d3d0-4cdc-beef-01cf771e0ce9" />

<img width="655" height="878" alt="image" src="https://github.com/user-attachments/assets/b66ff669-40fb-46af-a11c-376dd33a5ea2" />

<img width="655" height="579" alt="image" src="https://github.com/user-attachments/assets/83f03bec-6965-491b-b5f2-7e8732621b3b" />

<img width="1873" height="874" alt="image" src="https://github.com/user-attachments/assets/b75f6365-916e-41d8-9a4b-4b3e7aaf50ec" />

<img width="1040" height="157" alt="image" src="https://github.com/user-attachments/assets/6775f738-3b68-480d-bf87-b56d5650b1d5" />


<img width="1878" height="745" alt="image" src="https://github.com/user-attachments/assets/acadd79a-2ff6-4ee3-9560-0048d6679d63" />

<img width="1878" height="808" alt="image" src="https://github.com/user-attachments/assets/edb523d2-0f18-4b0b-9191-4d4df28da5a1" />

<img width="1867" height="854" alt="image" src="https://github.com/user-attachments/assets/7970c826-04f5-49d5-bfbf-54d7ac1a3bc1" />

<img width="1878" height="694" alt="image" src="https://github.com/user-attachments/assets/f3ab3a87-6ada-48c6-815d-36578169c711" />

<img width="1875" height="857" alt="image" src="https://github.com/user-attachments/assets/6916c1b1-0f23-48ec-af34-ddc2e26b8080" />

<img width="1869" height="633" alt="image" src="https://github.com/user-attachments/assets/50284ffe-5813-4857-b9b0-4993e6a5d06a" />

<img width="1883" height="623" alt="image" src="https://github.com/user-attachments/assets/5b535eba-2814-4bc1-9593-04fcc48c23d9" />

<img width="1878" height="692" alt="image" src="https://github.com/user-attachments/assets/a4632a9f-60ca-469a-87a0-8dd32a3213c9" />

<img width="1878" height="328" alt="image" src="https://github.com/user-attachments/assets/56cd2dac-1cc1-4178-94bb-fb4a6b9c33d1" />

<img width="1878" height="343" alt="image" src="https://github.com/user-attachments/assets/dc9addcd-adb9-442c-a582-e9f363f6c058" />

<img width="1868" height="626" alt="image" src="https://github.com/user-attachments/assets/ac588ea5-d25d-45e8-8364-f88a27c46dae" />

<img width="1881" height="886" alt="image" src="https://github.com/user-attachments/assets/a8b1dd8e-2ba2-48cf-aa3d-a0eb1eba252e" />

<img width="1878" height="635" alt="image" src="https://github.com/user-attachments/assets/7ddef0af-cab8-46a7-869f-664adce0f14a" />

<img width="1868" height="630" alt="image" src="https://github.com/user-attachments/assets/c923bed1-22aa-4a1d-92fe-74358fb6bd72" />

<img width="1865" height="847" alt="image" src="https://github.com/user-attachments/assets/18905317-1a7d-4f9a-afed-43a816b81e36" />

<img width="289" height="84" alt="image" src="https://github.com/user-attachments/assets/389b6369-3fd8-426c-970b-65479e6d223e" />

<img width="1501" height="551" alt="image" src="https://github.com/user-attachments/assets/4d60fb35-00a2-46fb-a76b-e3de1ea064ba" />

<img width="664" height="520" alt="image" src="https://github.com/user-attachments/assets/6c8333f3-64d6-49ce-a6f6-0b2e04f90223" />
















