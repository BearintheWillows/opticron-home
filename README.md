# Verto Test - Opticrom Homepage

## Note Regarding CMS

I have made a couple of assumptions regarding the CMS.

- The admin is already logged in. I have not implemented auth. Editable content is editable on page load.
- Only content within the Header and Footer is editable in the 3 main sections - Media Objects, Special Offers and Product Categories
- Section Headings and the "View All offers" button are not editable.
- Content is editable by clicking on the text and then a textbox will appear. Once you have clicked outside of the box then it will dissapear and the data will be sent and saved to the database. The changes will remain on page refresh.

## Note Regarding Database

The Database I have chosen is MSSQL Server. All intial data as per the png images provided will be seeded on initial creation of the database.

## Note Regarding Responsiveness / CSS

CSS is perhaps my weakest skill, however, I have done my best within the time I had. The CSS code is not clean. I prioritised getting it to work and to attempt to be as close to the images as possible. I have also never used the Foundation Framework before. I will not that a couple of times I have used "!important" to force a css change, although I understand the implications of that and would rarely if ever use it in a production environment.

## Note Regarding Testing Responsivness

To test the Small, Medium and Large configurations I used Google Chrome Dev tools witht he following:

Small - Samsung Galaxy S8+
Medium - Ipad Air
Large - "Responsive" set to 1920 pixels

Tools Used: 

- Jetbrains Rider

Tech Used:

- SlickJS
- Foudnation Framework
- MVC
- Icons by FontAwesome
