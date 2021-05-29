function countIf(head, p) {
  
    function _countIf(node, p, count) {
        if (!node)
            return count;
        return _countIf(node.next, p, count + (p(node.data) ? 1 : 0));
    }
  
    return _countIf(head, p, 0);
}