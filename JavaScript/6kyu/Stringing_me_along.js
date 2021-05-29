function createMessage(prev) {
  return (next) => next ? createMessage(`${prev} ${next}`) : prev;
}