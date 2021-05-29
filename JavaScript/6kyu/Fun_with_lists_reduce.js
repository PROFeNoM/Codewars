function reduce(head, f, init) {
    
    function _reduce(node, f, prev) {
        if (!node)
            return prev;
        return _reduce(node.next, f, f(prev ,node.data));
    }
  
    return _reduce(head, f, init);
}