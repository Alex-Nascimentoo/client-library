import ClientCard from "../components/clientCard"

function ClientList() {
  const clientList = [
    {
      name: "First Client",
      email: "first@example.com"
    },
    {
      name: "Second Client",
      email: "second@example.com"
    }
  ]

  return (
    <main>
      <h1 className="text-3xl font-bold text-sky-400">This is the listing page</h1>
      <section className="container m-auto pt-4 flex gap-9">
        {
          clientList.map(client => (
            <ClientCard name={client.name} email={client.email} />
          ))
        }

        {/* <ClientCard />
        <ClientCard /> */}
      </section>
    </main>
  )
}

export default ClientList