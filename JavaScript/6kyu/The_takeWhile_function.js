function takeWhile(arr, pred) {
  
    function _takeWhile(arr, pred, i, seq) {
        if (i >= arr.length || !pred(arr[i]))
            return seq;
        return _takeWhile(arr, pred, i + 1, [...seq, arr[i]]);
    }
  
    return _takeWhile(arr, pred, 0 , []);
}