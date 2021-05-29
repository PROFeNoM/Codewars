function isAgeDiverse(list) {
  const ageGroups = list
    .map((obj) => obj.age)
    .map((age) => {
      if (age < 20) return "teens";
      else if (age < 30) return "twenties";
      else if (age < 40) return "thirties";
      else if (age < 50) return "forties";
      else if (age < 60) return "fifties";
      else if (age < 70) return "sixties";
      else if (age < 80) return "seventies";
      else if (age < 90) return "eighties";
      else if (age < 100) return "nineties";
      else return "centenarian";
    });
  
  return ageGroups.filter((e, i) => ageGroups.indexOf(e) === i).length === 10;
    
}