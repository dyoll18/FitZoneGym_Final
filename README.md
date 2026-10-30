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

## UI editing rules (para hindi nawawala ang controls)

Lahat ng screen (Members, Plans, Staff, Reports, ...) ay nag-inherit sa `ShellForm`.

1. **Header buttons** (Add Member / Add Plan / Add Staff, atbp.) ay dapat nasa `actionsFlow`
   (Dock Right, auto-size). Huwag lagyan ng Location / Anchor - flow layout ang bahala.
2. **Title** ay `titleLabel` (Dock Fill). Huwag i-set ang Size ng `titleLabel`, `headerPanel`, `contentPanel` sa derived forms.
3. **Bawat control** na ginawa sa designer ay dapat may parent (`Controls.Add`). Kapag wala, mawawala ito sa runtime at kapag nag-save ang designer.
4. Gamitin ang Dock / TableLayoutPanel / FlowLayoutPanel para sa layout, hindi absolute Location, para hindi mapuputol sa ibang DPI/laki ng window.
5. Ang `Visible` ng Add button ay kinokontrol din ng permission sa code (`Perm.RegisterMembers`, `Perm.ManagePlans`) - Administrator ay nakikita lahat.
