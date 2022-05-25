Feature: MainPage

Sahibinden Main Page Tests

@tag1
Scenario: MainPageOpeningControl
	* Main page open

@tag1
Scenario: MainPageVehicleCategoriesControl
	* Main page open
	* Show all of them click
	* Is visible 'Otomobil' vehicles category
	* Is visible 'Arazi, SUV & Pickup' vehicles category
	* Is visible 'Motosiklet' vehicles category
	* Is visible 'Minivan & Panelvan' vehicles category
	* Is visible 'Ticari Araçlar' vehicles category
	* Is visible 'Elektrikli Araçlar' vehicles category
	* Is visible 'Kiralık Araçlar' vehicles category
	* Is visible 'Deniz Araçları' vehicles category
	* Is visible 'Hasarlı Araçlar' vehicles category
	* Is visible 'Klasik Araçlar' vehicles category
	* Is visible 'Modifiye Araçlar' vehicles category
	* Is visible 'Hava Araçları' vehicles category
	* Is visible 'ATV' vehicles category
	* Is visible 'UTV' vehicles category
	* Is visible 'Karavan' vehicles category
	* Is visible 'Engelli Plakalı Araçlar' vehicles category
	
@tag1
Scenario: MainPageRealEstateCategoriesControl
	* Main page open
	* Is visible 'Konut' real estate category
	* Is visible 'İş Yeri' real estate category
	* Is visible 'Arsa' real estate category
	* Is visible 'Bina' real estate category
	* Is visible 'Devre Mülk' real estate category
	* Is visible 'Turistik Tesis' real estate category
		
@tag1
Scenario: MainPageNavigationBarControl
	* Main page open
	* Is visible logo
	* Is visible Detail Search
	* Is visible Sign In
	* Is visible Sign Out
	* Is visible Free Advertise
	* Is visible Search Bar
	* Search Bar click
	* Is visible Search Bar search button
	* Is visible Search Bar close button
			
@tag1
Scenario: MainPageAdsControl
	* Main page open
	* Is visible Ads
	

	

