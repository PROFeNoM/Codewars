var Vector = function(components) {  
    this.vector = components;
    
    function operation(fn, v1, v2) {
        return new Vector(fn(v1, v2));
    }
  
    this.add = function(to_add) {
        if (this.vector.length !== to_add.vector.length)
            throw Error("Vectors don't have the same length.");
        return operation((v1, v2) => v1.map((v, i) => v + v2[i]), this.vector, to_add.vector);
    };
    
    this.subtract = function(to_subtract) {
        if (this.vector.length !== to_subtract.vector.length)
            throw Error("Vectors don't have the same length.");
        return operation((v1, v2) => v1.map((v, i) => v - v2[i]), this.vector, to_subtract.vector);
    };
  
    this.dot = function(to_dot) {
        if (this.vector.length !== to_dot.vector.length)
            throw Error("Vectors don't have the same length.");
        return operation((v1, v2) => v1.map((v, i) => v * v2[i]), this.vector, to_dot.vector).vector.reduce((prev, curr) => prev + curr, 0);
    };
  
    this.norm = function() {
        return Math.sqrt(this.vector.map((v) => v ** 2).reduce((prev, curr) => prev + curr, 0));
    }
  
    this.toString = function() {
      
        function _stringizer(arr, i, separator, result) {
            if (i === 0)
                return _stringizer(arr, i + 1, separator, `${arr[i]}`);
            if (arr.length - 1 === i)
                return `${result}${separator}${arr[i]}`;
            return _stringizer(arr, i + 1, separator, `${result}${separator}${arr[i]}`);
        }
        
        return `(${_stringizer(this.vector, 0, ',', "")})`;
    };
    
    this.equals = function(to_compare) {
        if (this.vector.length !== to_compare.vector.length)
            return false;
        return to_compare.vector.map((v, i) => v === this.vector[i]).indexOf(false) === -1;
    };
};