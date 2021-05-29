// partition the items array so that all values for which pred returns true are
// at the end, returning the index of the first true value
function partitionOn(pred, items) {
    const falseItems = items.filter((v) => !pred(v));
    const trueItems = items.filter((v) => pred(v));
    const newItems = falseItems.concat(trueItems);
    for (let i = 0; i < items.length; i++) items[i] = newItems[i];
    return falseItems.length;
}