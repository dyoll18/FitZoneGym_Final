# FITZONE GYM — Basic Windows Desktop App

A simplified C# Windows Forms gym membership management system using SQLite.

## Included features
- Login
- Dashboard
- Member management (add, edit, search, view)
- Membership plans
- Membership registration and renewal
- Payment recording
- Local SQLite database

Advanced feature forms have been removed from this basic edition: staff management, freezing/reactivation, invoices, prorated billing, reports, settings, and backup screens.

## Requirements
- Windows
- Visual Studio 2022 or newer
- .NET desktop development workload
- Internet connection on first build to restore the SQLite NuGet package

## Run
1. Extract the ZIP.
2. Open `FitZoneGym.csproj` in Visual Studio.
3. Restore NuGet packages.
4. Press F5.
5. The app creates its database on first run at `%LocalAppData%\FitZoneGym\fitzone.db`.

## Demo accounts
- Administrator: `admin` / `Admin@123`
- Staff: `staff1` / `Staff@123`
- Cashier: `cashier1` / `Cashier@123`

These are demo credentials; change them before using real data.


## Basic edition modules
This edition includes Dashboard, Members, Membership Plans, Registration & Renewal, Payments, Reports Generation (CSV export), and User Management (accounts, roles/permissions, activity log). Advanced modules such as freeze management, reactivation, prorated billing, invoices, settings, and backup screens are excluded from navigation and the project files.


## UI theme (dark "gym" edition)
- All colours/fonts live in `Helpers/Ui.cs`; `Helpers/Theme.cs` styles every control from its `Tag`
  (`card`, `primary`, `secondary`, `success`, `danger`, `h1`, `h2`, `caption`, ...).
- Screens are built with Dock / TableLayoutPanel / FlowLayoutPanel only (no absolute pixel positions), so nothing overlaps
  at any Windows display scaling.
- The logo is drawn in code (`Controls/LogoMark.cs`) - no image files needed. It is used on the login screen, the sidebar
  and as the window icon.
- Pop-ups (`Ui.Info/Warn/Error/Confirm`) use a themed dialog instead of the grey system MessageBox.
