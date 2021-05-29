function List() {}

function EmptyList() {}
EmptyList.prototype = new List();
EmptyList.prototype.constructor = EmptyList;

EmptyList.prototype.toString = function() { return '()'; };
EmptyList.prototype.isEmpty = function() { return true; };
EmptyList.prototype.length = function() { return 0; };
EmptyList.prototype.push = function(x) { return new ListNode(x, this); };
EmptyList.prototype.remove = function(x) { return this; };
EmptyList.prototype.append = function(xs) { return xs; };

function ListNode(value, next) { this.data = value; this.next = next; }
ListNode.prototype = new List();
ListNode.prototype.constructor = ListNode;
ListNode.prototype.isEmpty = function() { return false; };

ListNode.prototype.toString = function() {
  let next = this.next;
  let strList = [ this.data ];
  while (!next.isEmpty()) {
    strList.push(next.data);
    next = next.next;
  }
  return '(' + strList.join(' ') + ')';
};

ListNode.prototype.head = function() { return this.data; };
ListNode.prototype.tail = function() { return this.next; };
ListNode.prototype.length = function() { return 1 + this.next.length(); };
ListNode.prototype.push = function(x) { return new ListNode(x, this); };
ListNode.prototype.remove = function(x) {
  let tmp = this.next.remove(x);
  if (x == this.data) return tmp;
  if (tmp == this.next) return this;
  else return new ListNode(this.data, tmp);
};
ListNode.prototype.append = function(xs) { return new ListNode(this.data, this.next.append(xs)); };