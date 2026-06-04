# ----------------------------
# CMPT291-X02L Spring, 2026 | Group 1
#
# This script is meant to generate dummy data for the MovieRentalDB.
# Applicable to all tables.
#
# Author: Inas BangsaJayah
# ----------------------------

import random

#SQL Data Types

class Numeric:
    def __init__(self, intPrec = 1, decPrec = 1):
        self.intPrec = intPrec #int
        self.decPrec = decPrec #int
        self.intVal = '0'*intPrec #string
        self.decVal = '0'*decPrec #string
        return
    def __str__(self):
        return f"{self.intVal[:self.intPrec]}.{self.decVal[:self.decPrec]}"
    
    def assign(self, intVal, decVal = None):
        #To-do: Needs formatting to pad left
        self.intVal = f"{intVal:0{self.intPrec}d}" #string
        self.intVal = self.intVal[:self.intPrec]
        if decVal != None:
            self.decVal = f"{decVal:0{self.intPrec}d}" #string
            self.decVal = self.decVal[:self.decPrec]
        return

    def randAssign(self, numMin, numMax):

        #To-do: Pad based on L/R Precision
        intMin = int(f"{numMin.intVal[:self.intPrec]}{numMin.decVal[:self.decPrec]}")
        intMax = int(f"{numMax.intVal[:self.intPrec]}{numMax.decVal[:self.decPrec]}")
        strVal = str(random.randint(intMin, intMax))

        self.intVal = strVal[ :self.intPrec]
        self.intVal = strVal[self.intPrec: ]
        return

class Date:
    def __init__(self, year = 0, month = 0, day = 0):
        self.year = year    #int
        self.month = month  #int
        self.day = day      #int
        return
    def __str__(self):
        return f"{self.year}-{self.month}-{self.day}"

# Table creator / CSV creator

class Tables:
    def __init__(self):
        Customer = Customers(3)
        Employee = 2
        Movies = 3
        Rental = 4
        MovieQueue = 5
        Distributors = 6
        Actor = 7
        
        return

class Customers:
    
    #Writes an insert query for the Customer table
    #
    #FILE file - The file to write into
    #int rows - number of rows to insert
    def write_table(file, rows):
        file.write("INSERT INTO Customer VALUES\n")
        fields = [None for x in range(11)]
        for r in range(rows):
            Customers.make_row(r, fields)
            write_query(file, fields)
            if (r == rows-1):
                file.write(";\n\n")
            else:
                file.write(",\n")
        
        print("Successfully made Customer table.")
        return
    
    # Generates a row for the Customer table
    #
    # int CID - Unique ID of customer (row)
    # tuple fields - tuple of size 11 that holds row information
    def make_row(CID, fields):
        #CID
        fields[0] = CID
        #FName, LName
        fields[1], fields[2] = Generate.name()
        #Address, City, Province, PostalCode
        fields[3], fields[4], fields[5], fields[6] = Generate.location()
        #Email (LName1@email.com)
        fields[7] = f"{fields[2][:-1]}{CID}@email.com'"
        #Account Creation Date
        fields[8] = Generate.date(2010,2020)
        #Phone number
        fields[9] = Generate.phone()
        #Payment Identifier
        fields[10] = CID
        
        return

class Employees:
    
    #Writes an insert query for the Employee table
    #
    #FILE file - The file to write into
    #int rows - number of rows to insert
    def write_table(file, rows):
        file.write("INSERT INTO Employee VALUES\n")
        fields = [None for x in range(9)]
        for r in range(rows):
            Employees.make_row(r, fields)
            write_query(file, fields)
            if (r == rows-1):
                file.write(";\n\n")
            else:
                file.write(",\n")
        
        print("Successfully made Employee table.")
        return
    
    # Generates a row for the Employee table
    #
    # int EID - Unique ID of employee (row)
    # tuple fields - tuple of size 9 that holds row information
    def make_row(EID, fields):
        #EID
        fields[0] = EID
        #FName, LName
        fields[1], fields[2] = Generate.name()
        #Address, City, Province, PostalCode
        fields[3], fields[4], fields[5], fields[6] = Generate.location()
        #Phone number
        fields[7] = Generate.phone()
        #Start Date
        fields[8] = Generate.date(2010,2020)
        
        return

class Actor:
    
    #Writes an insert query for the Actor table
    #
    #FILE file - The file to write into
    #int rows - number of rows to insert
    def write_table(file, rows):
        file.write("INSERT INTO Actor VALUES\n")
        fields = [None for x in range(7)]
        for r in range(rows):
            Actor.make_row(r, fields)
            write_query(file, fields)
            if (r == rows-1):
                file.write(";\n\n")
            else:
                file.write(",\n")
        
        print("Successfully made Actor table.")
        return
    
    # Generates a row for the Actor table
    #
    # int AID - Unique ID of actor (row)
    # tuple fields - tuple of size 9 that holds row information
    def make_row(AID, fields):
        #AID
        fields[0] = AID
        #FName, LName
        fields[1], fields[2] = Generate.name()
        #Gender, Ethnicity
        fields[3], fields[4] = Generate.demographic()
        #Date of Birth
        fields[5] = Generate.date(1950,2020)
        #Rating
        fields[6] = random.randint(0,100)
        
        return

class Distributor:
    def __init__(self):
        self.table = []
        
        return

    def make_table(self, file, rows):
        for r in range(rows):
            self.table.append([None for x in range(3)])
            Distributor.make_row(r, self.table[-1])
        
        print("Successfully made Distributor table.")
        return
    
    #Writes an insert query for the Distributor table
    #
    #FILE file - The file to write into
    #int rows - number of rows to insert
    def write_table(self, file, rows):
        file.write("INSERT INTO Distributor VALUES\n")
        for r in range(rows):
            write_query(file, self.table[r])
            if (r == rows-1):
                file.write(";\n\n")
            else:
                file.write(",\n")
        
        print("Successfully wrote Distributor table.")
        return

    # Generates a row for the Distributor table
    #
    # int DistID - Unique ID of distributor (row)
    # tuple fields - tuple of size 3 that holds row information    
    def make_row(DistID, fields):
        #DistID
        fields[0] = DistID
        #Dname
        fields[1] = f"'Distributor{DistID}'"
        #BulkPrice
        fields[2] = Numeric(2,2)
        fields[2].assign(random.randint(5,99), random.randint(0,99))
        
        return

class Movie:

    # FILE file - File to write into
    # Distributor dist - Class that gives access to distributor data
    # int rows - number of rows to make
    def write_table(file, dist, rows):
        file.write("INSERT INTO Movie VALUES\n")
        fields = [None for x in range(8)]
        for r in range(rows):
            Movie.make_row(r, dist.table[r], fields)
            write_query(file, fields)
            if (r == rows-1):
                file.write(";\n\n")
            else:
                file.write(",\n")
        
        print("Successfully made Movie table.")
    
    # Generates a row for the Movie table
    #
    # int MovieID - Unique ID of movie (row)
    # int Dist - List/Row containing info of the distributor that distributes the movie
    # list fields - list of size 9 that holds row information
    def make_row(MovieID, Dist, fields):
        #MovieID
        fields[0] = MovieID
        #Title
        fields[1] = f"'Movie{MovieID}'"
        #Genre
        fields[2] = Generate.genre()
        #Quantity
        fields[3] = random.randint(0,20)
        #PopScore, RateCount
            #Score is set as an integer as a placeholder. We can change this to some float/numeric
        fields[4], fields[5] = random.randint(0,100), random.randint(0,100)
        #Release
        fields[6] = Generate.date(1950,2020)
        #Price
        priceMax = Numeric(2,2)
        priceMax.assign(99,99)
        fields[7] = Numeric(2, 2)
        fields[7].randAssign(Dist[2], priceMax)
        
        return

class null:
    def write_table(file, rows):
        return
    def make_row(EID, fields):
        return

#Auxiliary functions/classes

def write_query(file, fields):
    query = "("
    for f in range(len(fields)):
        query += f"{fields[f]}, "
    file.write(query[:-2] + ')')
    return
    

class Generate:
    
    def date(lower, upper):
        day = random.randint(1, 30)
        month = random.randint(1, 12)
        year = random.randint(lower, upper)
        
        return Date(year, month, day)
    
    def name():
        Fname = ["Alice", "Artoria", "Rodion", "Mohammed", "Federico", "Friedrich",
                 "John", "Jane", "Julius", "Steven", "Zuo", "Lemuel", "Enciodes",
                 "Ermengarde", "Kaschey", "Jeffery", "Farzan", "Lavinia", "Carlos",
                 "Varlaqvin", "Kim", "Violet", "Christine", "Yato", "Maria", "Shana",
                 "Margarette", "Zofia", "Laurentina", "Emil", "Jorge", "Ingrid",
                 "Yuri", "Luka", "Baoyu", "Lucian", "Qiu", "Liang", "Imran", "Jin",
                 "Karen", "Carmen", "Fiona", "Benjamin", "Axl"]
        Lname = ["Droste", "Giallo", "Smith", "Wright", "Edwards", "Jung", "Santos",
                 "Tolkien", "Romanovich", "Liszt", "Schuuman", "Park", "Mlynar",
                 "Alighieri", "Dostoevsky", "Earnshaw", "Falcone", "Huang", "Lee",
                 "Sinclair", "Kramer", "Riemann", "Jia", "Kong", "Zhuge", "Liu",
                 "Patel", "Hussein", "Nguyen", "Tran", "Khan", "Bulsara", "Young",
                 "Hui-Chieh", "Kiske"]
        
        pickF = random.randint(0, len(Fname)-1)
        pickL = random.randint(0, len(Lname)-1)
        
        return ( f"'{Fname[pickF]}'", f"'{Lname[pickL]}'" )
    
    def location(): # address, city, province, pcode
        loc = [None for x in range(4)]
        address = ["street", "ave"]
        city = ["Edmonton", "Calgary"]
        province = ["AB", "BC", "ON"]
        pcode = ["A1B2C3", "D4E5F6", "H7J8K9"]
        
        loc[0] = f"'{address[random.randint(0, len(address)-1)]}'"
        loc[1] = f"'{city[random.randint(0, len(city)-1)]}'"
        loc[2] = f"'{province[random.randint(0, len(province)-1)]}'"
        loc[3] = f"'{pcode[random.randint(0, len(pcode)-1)]}'"
        
        return loc
    
    def phone(): # Allows for duplicates
        areaCode = ["403", "587", "780", "825"]
        phone = f"({areaCode[random.randint(0, len(areaCode)-1)]}) "
        
        for n in range(3):
            phone += str(random.randint(0,9))
        phone += "-"
        for n in range(4):
            phone += str(random.randint(0,9))
        
        return f"'{phone}'"
    
    def demographic(): # Gender, Ethnicity
        # Binary, but can be manually changed
        Gender = ["male", "female"]
        # Covering only continents for ease
        Ethnicity = ["European", "African", "Asian", "Australian",
                     "North American", "Central American", "South American"]
        
        pickG = random.randint(0, len(Gender)-1)
        pickE = random.randint(0, len(Ethnicity)-1)

        return ( f"'{Gender[pickG]}'", f"'{Ethnicity[pickE]}'" )
    
    def genre():
        genres = ["Horror", "Sci-fi", "Urban Fantasy", "Romance", "Grimdark",
                  "Mecha", "Action", "Coming-of-age", "True Crime", "Fantasy",
                  "Drama", "Thriller", "Tragedy", "Historical", "Sports", "Comedy",
                  "Crime", "Cyberpunk", "Documentary"]
        pick = random.randint(0, len(genres)-1)
        return f"'{genres[pick]}'"

        

if __name__ == "__main__":
    print("Generating...")
    
    #Change to whatever filename you want
    filename = "InsertTables.sql"
    #NOTE: ROWS ARE SHARED ACROSS ALL TABLES FOR NOW
    rows = 10

    try:
        with open(filename, 'w') as file:
            Customers.write_table(file, rows)
            Employees.write_table(file, rows)
            Actor.write_table(file, rows)

            Dist = Distributor()
            Dist.make_table(file, rows)
            Dist.write_table(file, rows)

            Movie.write_table(file, Dist, rows)
    except Exception as error:
        print(f"Failed to write table.\n{error}") 