def value(make, model, year, mileage, accidents):   
    value = 10000   

    if make == "Toyota":   
        if model == "Camry":   
            value -= 2000   
        elif model == "Corolla":   
            value -= 1500   
        elif model == "Rav4":   
            value -= 1000   
    elif make == "Honda":   
        if model == "Accord":   
            value -= 2000   
        elif model == "Civic":   
            value -= 1500   
        elif model == "CR-V":   
            value -= 1000   
    elif make == "Ford":   
        if model == "Focus":   
            value -= 2000   
        elif model == "Fusion":   
            value -= 1500   
        elif model == "Escape":   
            value -= 1000   
   
    if year < 2010:   
        value -= 3000   
    elif year < 2015:   
        value -= 2000   
    elif year < 2020:   
        value -= 1000   
   
    if mileage > 100000:   
        value -= 2000   
    elif mileage > 50000:   
        value -= 1000   
   
    if accidents > 3:   
        value -= 2000   
    elif accidents > 1:   
        value -= 1000   

    return value   

   

   

car1 = calculate_car_value("Toyota", "Camry", 2014, 80000, 2)   

print("Car 1 value:", car1)   

car2 = calculate_car_value("Honda", "Accord", 2011, 120000, 0)   

print("Car 2 value:", car2)   

car3 = calculate_car_value("Ford", "Focus", 2018, 40000, 1)
print("Car 3 value:", car3)   