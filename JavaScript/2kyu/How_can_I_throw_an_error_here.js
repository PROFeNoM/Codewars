function bang(){
    try {NaN();}
    catch (e) {
        (function*(){})()['t' + 'hrow'](new e.__proto__.__proto__.constructor('Just t' + 'hrow like this!'));
    }
}