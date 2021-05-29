function once(fn) {
    let flag = false;
    return function(...args) { 
        if (!flag) { 
            flag = true;
            return fn.apply(this,args);
        }
    }
} 