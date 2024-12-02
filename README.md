
# Boylam Restaurant Report Application

The Boylam Restaurant Report Application is a Windows Forms application developed using Visual Studio and MSSQL. This application is designed to help restaurants generate store-based reports, manage users, and view historical data efficiently.

## Features

- **User Management**: Users can log in using credentials stored in the MSSQL database. The application includes a login screen and checks user credentials before allowing access.
- **Store Management**: Manage stores with store name, store number, IP address, and port information, saved in XML format. The application can read, display, and update store information.
- **Report Generation**: Generate end-of-day reports for selected stores. Reports are saved as PDFs with a specific naming convention that includes store name, date, and report type.
- **Report History**: View previously generated reports. Users can search and filter reports based on criteria like store name and date.
- **Local Network Integration**: The application can interact with different stores over a local network using the IP address and port information.
- **Help Screen**: A help screen provides the developer's contact information for support.

## Requirements

- **Development Environment**: Visual Studio 2010
- **Database**: Microsoft SQL Server
- **.NET Framework**: Compatible with the version supported by Visual Studio 2010
- **Configuration Files**: Store configuration is managed using XML files stored in the file system

## Installation

1. **Clone the Repository**: You can clone the project repository to your local machine.
   ```bash
   git clone https://github.com/keskinmertcan/boylam-restaurant-report.git
   ```

2. **Configure the Database**:
   - Select MSSQL database named `BYBS`.
   - Import the necessary database tables and data (e.g., `SISTEM_KULLANICILARI`, store information, etc.).

3. **Update Configuration Files**:
   - XML files for store management need to be placed in the application's root directory.
   - These files should include store details like Store Name, IP Address, and Port Number.

4. **Build the Application**:
   - Open the project in Visual Studio 2010.
   - Build the solution and run the application.

## Usage

- **Login Screen**: Users start with the login screen where they need to provide their credentials. The application verifies the credentials against the `SISTEM_KULLANICILARI` table in the MSSQL database.
- **Menu Structure**:
  - **Tanımlar (Definitions)**: Manage stores, add new stores, and view/edit existing store information.
  - **Raporlar (Reports)**: Generate new reports and view historical reports.
  - **Yardım (Help)**: Access contact details for technical support.
  - **Çıkış (Exit)**: Exit the application.
- **Reports**: Users can select a store, connect to the store's database using the configured IP and port, and execute an `.rtm` file to generate a report. The report is saved as a PDF and opened automatically.

## Screens

1. **Login Screen**: Authenticates users using credentials stored in the `BYBS` database.
2. **Store Management**: Add, edit, and view store information. Store details are stored in XML format.
3. **Report Generation**: Select a store, generate a report, and view the results.
4. **Report History**: View previously generated reports with filtering options.
5. **Help Screen**: Displays contact information for support.

## Configurations

- **XML Store Configuration**: Store information such as Store Name, IP Address, and Port is saved in an XML file in the file system.
- **Database Configuration**: MSSQL server is used to manage users, store-related data, and report-related information.

## Security

- The login system ensures that only authorized personnel have access to the reporting functionalities.
- User roles can be managed within the MSSQL database, ensuring different levels of access.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! If you have ideas for improving the application or new features, feel free to submit a pull request or raise an issue.

---

This project aims to streamline the reporting process for restaurants by providing an easy-to-use interface for generating and managing end-of-day reports.

### Notes

- The application is designed specifically for use in restaurant environments that need to generate store-specific reports.
- Currently, the application supports only a single language (Turkish), but future updates may include multi-language support.
