function filter(head, p) {
  
    function _listToArr(node, arr) {
        if (!node)
            return arr;
        return _listToArr(node.next, [...arr, node.data]);
    }
  
  
    return _listToArr(head, [])
              .filter(p)
              .reverse()
              .reduce((prev, curr) => new Node(curr, prev), null);
}