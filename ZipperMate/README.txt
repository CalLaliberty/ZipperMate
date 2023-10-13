Author: Clay Laliberty
Program Name: ZipperMate
Program Purpose: ASP.net App for "Zipper"
Date: 2023-10-05


-------------------------------------------------------------
                        2023-10-05 📅
10:30 PM ⏰
-------------------------------------------------------------

Created a ASP.net App, run app everything works correctlly.

First file made is a README.txt to document my development of 
the App. Any issues and solutions can be found here.

-------------------------------------------------------------
10:33 PM ⏰ -  2023-10-05 📅
-------------------------------------------------------------

Created a Github repository so I can save my work and be able 
to us it on other devices as well with ease.

-------------------------------------------------------------
10:48 PM ⏰-  2023-10-05 📅
-------------------------------------------------------------

Made a About.cshtml file inside of views.

Updated HomeController.cs with this block of code:

public IActionResult About()
        {
            return View();
        }

Also updated Views/Home/Shared/_Layout.cshtml and added "About Us"
to the nav bar.

<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="About">About Us</a> <!-- This is where the About us link is in nav -->
</li>

-------------------------------------------------------------
10:50 PM ⏰ -  2023-10-05 📅
-------------------------------------------------------------

Ran program. No issues or errors. About Us link works correctly. 

Update About us with some basic text's just to see what it will look like, I
will update with more info later.

-------------------------------------------------------------
11:00 PM ⏰ -  2023-10-05 📅
-------------------------------------------------------------

Created a new file called Zipper.cs in Models/

namespace ZipperMate.Models
{
    public class Zippers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Use { get; set; }

        public string Durabilty { get; set; }
        public decimal Price { get; set; }

        public string Colours { get; set; }
    }
}

Already had Microsoft.EntityFrameworkCore.SqlServer installed.

-------------------------------------------------------------
11:20 PM ⏰ -  2023-10-05 📅
-------------------------------------------------------------

Created my Data file Data/ZipperMateContext.cs

using Microsoft.EntityFrameworkCore;
using ZipperMate.Models; 

namespace ZipperMate.Data
{
    public class ZipperContext : DbContext
    {
        public ZipperContext(DbContextOptions<ZipperContext> options)
            : base(options)
        {
        }

        public DbSet<ZipperMate.Models.Zippers> Zippers { get; set; }
    }
}

No errors or warnings with this code used.

-------------------------------------------------------------
11:25 PM ⏰ -  2023-10-05 📅
-------------------------------------------------------------

Created a new scaffolded item from Controllers->Add->New Scaffolded item

Zipper(ZipperMate.Models)
ZipperMate.Data.ZipperMateContext

Select Add.

Build was successful, no issues or errors.

-------------------------------------------------------------
11:30 PM ⏰ -  2023-10-05 📅
-------------------------------------------------------------

Ran these commands into NuGet Package Manager (PMC)

Add-Migration InitialCreate -context ZipperMateContext
Update-Database -context ZipperMateContext

Was having issues, make sure to have -context "name" of file.

-------------------------------------------------------------
11:35 PM ⏰ -  2023-10-05 📅
-------------------------------------------------------------

Tested app, no issues or errors. Was able to add a zipper to the page and edit it as well.

Save and update README and push to GitHub.

-------------------------------------------------------------
12:15 AM ⏰ -  2023-10-05 📅
-------------------------------------------------------------

Created a file called SeedData.cs Models/

Updated code in the file with my seed data to display in zippers.

Created some text just to test code, will update with correct info.

Updated code in Program.cs

Deleted everything in table for seed data.

Test the app, no issues or errors the data all apears on the page.

Update README and push to Github.

-------------------------------------------------------------
                         2023-10-06 📅
10:55 AM ⏰
-------------------------------------------------------------

Updated code in _Layout.cshtml.

Changed the date on the footer so it gives the current date and time.
This way I never have to manual update it.

Changed "Home" to  "Zippers" this way the user can click
the "logo" and go to the inventory.

-------------------------------------------------------------
11:18 AM ⏰ - 2023-10-06 📅
-------------------------------------------------------------

I forgot to add a section for a review on the product.

Updated code in zippers.cs to add a new property called "Review"

Updated code in Controllers/ZipeerController.cs
Changed bind code and added Review (Create & Edit)

Updated code in Views/Zipper/Index.cshtml
Updated code in Views/Zipper/Create.cshtml and Edit.cshtml

Updated code in Models/SeedData.cs - added Review.

Ran program, no issues or errors. Save and push to Github.

-------------------------------------------------------------
11:25 AM ⏰ - 2023-10-06 📅
-------------------------------------------------------------

I've successfully completed the creation of my Zipper page,
and everything is functioning as intended.

Next is the refinement of my content to
align with our company's identity and product offerings.
This involves enhancing the frontend and fine-tuning the
content across all my pages.

-------------------------------------------------------------
                         2023-10-07 📅
2:20 PM ⏰
-------------------------------------------------------------

Updated the index home page to welcome the user to ZipperMate
giving a short description of the company and what they offer.

Created a folder called fonts wwwroot/fonts
Placed my font files inside of font and inserted my line of 
code in the site.css.

@font-face {
    font-family: 'zen_dotsregular';
    src: url('/fonts/zendots-regular-webfont.woff2') format('woff2'), url('/fonts/zendots-regular-webfont.woff') format('woff');
    font-weight: normal;
    font-style: normal;
}

Ran program font is applied correctly.


-------------------------------------------------------------
3:30 PM ⏰ - 2023-10-07 📅
-------------------------------------------------------------

Added some cards at the bottom of the page to give more details about the product.

Filled in cards with stock images and text content.

Added some bootstrap style to make my cards line up horizontally.

Run code no errors or issues.

-------------------------------------------------------------
3:47 PM	⏰- 2023-10-07 📅
-------------------------------------------------------------

Updated About us page, with a more detailed about us.

Added a carousel to the top of the page to display some of the products.

Tested code. No issues.

-------------------------------------------------------------
4:25 PM ⏰ - 2023-10-07 📅
-------------------------------------------------------------

Deleted everything in my table and updated SeedDate to display 10 items 

Updated all the info for each new item.

Ran this command:

Update-Database -context ZipperMateContext

Ran program new items are populated.

No issues or errors.

-------------------------------------------------------------
5:00 PM ⏰ - 2023-10-07 📅
-------------------------------------------------------------

Added some colour to the body and footer 

Added my CSS template, to make my CSS more readable

Had issues with CSS not appearing on my webpage.

Clear browsing data in seemed to have resolved the issue, make note for future.

-------------------------------------------------------------
5:36 PM ⏰ - 2023-10-07 📅
-------------------------------------------------------------

Front end adjustments, Tested app. No issues or errors.


-------------------------------------------------------------
4:25 PM ⏰ - 2023-10-07 📅
-------------------------------------------------------------

Deleted everything in my table and updated SeedDate to display 10 items 

Updated all the info for each new item.

Ran this command:

Update-Database -context ZipperMateContext

Ran program new items are populated.

No issues or errors.

-------------------------------------------------------------
5:00 PM ⏰ - 2023-10-07 📅
-------------------------------------------------------------

Added some colour to the body and footer 

Added my CSS template, to make my CSS more readable

Had issues with CSS not appearing on my webpage.

Clear browsing data in seemed to have resolved the issue, make note for future.

-------------------------------------------------------------
5:36 PM ⏰ - 2023-10-07 📅
-------------------------------------------------------------

Made some Front-end adjustments, Tested app. No issues or errors.


-------------------------------------------------------------
                         2023-10-08 📅
4:35 PM ⏰
-------------------------------------------------------------

Final revison of content on page, layout looks nice and not to 
clutterd quick easy to read.

Ran program no issues or errors.

-------------------------------------------------------------
                         2023-10-10 📅
7:48 PM ⏰
-------------------------------------------------------------

Created a README.md on github, giving a breif description of my 
project.

-------------------------------------------------------------
8:00 PM	⏰  2023-10-10 📅
-------------------------------------------------------------

Added validation rules to the properties of Zippers.
This will prevent user inputing incorrect data into the table (GIGO).

Ran and tested program no issues or errors.

-------------------------------------------------------------
                         2023-10-13 📅
11:12 PM ⏰
-------------------------------------------------------------

Final check of code and webpage.

Run program no issues or errors.