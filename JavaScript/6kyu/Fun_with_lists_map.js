function map(head, f) {
  
  function _map(node, f) {
    if (node === null)
      return null;
    return new Node(f(node.data), _map(node.next, f));
  }
  
  return _map(head, f);
}