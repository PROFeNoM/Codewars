function BinaryTree() {};

function BinaryTreeNode(value, left, right) {
  this.value = value;
  this.left = left;
  this.right = right;
  Object.freeze(this);
}
BinaryTreeNode.prototype = new BinaryTree();
BinaryTreeNode.prototype.constructor = BinaryTreeNode;

BinaryTreeNode.prototype.isEmpty = function() { return false; };
BinaryTreeNode.prototype.depth = function() { return 1 + Math.max(this.left.depth(), this.right.depth()); };
BinaryTreeNode.prototype.count = function() { return 1 + this.left.count() + this.right.count(); };

BinaryTreeNode.prototype.inorder = function(fn) { this.left.inorder(fn); fn(this.value); this.right.inorder(fn); };
BinaryTreeNode.prototype.preorder = function(fn) { fn(this.value); this.left.preorder(fn);  this.right.preorder(fn); };
BinaryTreeNode.prototype.postorder = function(fn) { this.left.postorder(fn); this.right.postorder(fn); fn(this.value); };

BinaryTreeNode.prototype.contains = function(x) { return (this.value === x) ? true : ((x < this.value) ? this.left.contains(x) : this.right.contains(x)); };
BinaryTreeNode.prototype.insert = function(x) { 
    if (x instanceof BinaryTreeNode) {
        if (x.value < this.left.value || this.left.isEmpty())
            return new BinaryTreeNode(this.value, this.left.insert(x), this.right);
        return new BinaryTreeNode(this.value, this.left, this.right.insert(x));
    }
  
    if (x < this.value)
        return new BinaryTreeNode(this.value, this.left.insert(x), this.right);
    return new BinaryTreeNode(this.value, this.left, this.right.insert(x));
};
BinaryTreeNode.prototype.remove = function(x) { 
    if (!this.contains(x))
        return this;
    
    if (x < this.value) {
        const removed = this.left.remove(x)
        return removed === this.left ? this : new BinaryTreeNode(this.value, removed, this.right);
    } else if (this.value < x) {
        const removed = this.right.remove(x);
        return removed === this.right ? this : new BinaryTreeNode(this.value, this.left, removed);
    } else {
        if (!this.left.isEmpty() && this.right.isEmpty())
            return new BinaryTreeNode(this.left.value, this.left.left, this.left.right);
        else if(this.left.isEmpty() && !this.right.isEmpty())
            return new BinaryTreeNode(this.right.value, this.right.left, this.right.right);
        else if(this.left.isEmpty() && this.right.isEmpty())
            return this.left;
        else
            return this.right.insert(this.left);  
    }
};

////////////////////////////////////////////////////////////////////////
function EmptyBinaryTree() { Object.freeze(this); }
EmptyBinaryTree.prototype = new BinaryTree();
EmptyBinaryTree.prototype.constructor = EmptyBinaryTree;

EmptyBinaryTree.prototype.isEmpty = function() { return true; };
EmptyBinaryTree.prototype.depth = function() { return 0; };
EmptyBinaryTree.prototype.count = function() { return 0; };

EmptyBinaryTree.prototype.inorder = function(fn) { /* implement this */ };
EmptyBinaryTree.prototype.preorder = function(fn) { /* implement this */ };
EmptyBinaryTree.prototype.postorder = function(fn) { /* implement this */ };

EmptyBinaryTree.prototype.contains = function(x) { return false; };
EmptyBinaryTree.prototype.insert = function(x) { return (x instanceof BinaryTreeNode) ? x : new BinaryTreeNode(x, new EmptyBinaryTree(), new EmptyBinaryTree()); };
EmptyBinaryTree.prototype.remove = function(x) { return this; };