Features & Functionalities
1. Claim Submission and Approval
Lecturers can submit their claims, which consist of the number of hours worked and the corresponding hourly rate. Authorized users (Program Coordinators or Academic Managers) can approve or reject claims based on the submitted data.

Lecturers can enter claim details such as Lecturer Name, Hours Worked, and Hourly Rate.
Claims will appear in the system for approval once submitted.
2. Invoice Generation
Once a claim is approved, an invoice can be generated automatically.

Invoice Format: Includes details like Lecturer Name, Hours Worked, Hourly Rate, and Total Payment.
Invoices are generated as PDF files using the iTextSharp library, and can be saved or printed.
3. Lecturer Data Management
Administrators can update the personal information of lecturers, such as changing their names or contact details.

A simple form is available for updating lecturer information.
The data is updated in the database upon confirmation.
Application Flow
Submit Claims:
Lecturers submit claims via the Claims page. Claims are validated and added to the system.

Approve Claims:
A Program Coordinator or Academic Manager can view claims submitted by lecturers and approve or reject them.

Generate Invoice:
After a claim is approved, an invoice is generated and saved as a PDF.

Manage Lecturer Data:
Admin users can update the lecturer's personal information, such as their name, address, or contact details.

Database Operations
The application uses Entity Framework Core for interacting with the database. Key operations include:

Claims: Storing, retrieving, and updating claims.
Lecturers: Storing and updating personal lecturer information.
Invoices: Storing and retrieving invoices for approved claims.
You can modify the connection string in the appsettings.json file to connect to your own database.