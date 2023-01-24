<!-- TODO -->
<!-- ZROBIĆ JAK BĘDZIESZ MIAŁA ZROBIONE "HANDLE" -->

<!-- <a href="/tasks/{userId}/performer_tasks">
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>
{#if buildingInfoVisibility}
  <div>
    ZADANIE Z DNIA {setResultFormatIfItIsDateTime(
      "dueStartDateTime",
      inspectionTask.dueStartDateTime
    )}
  </div>
  <div>
    <table>
      <tr>
        <td>BUDYNEK</td>
        <td>{buildingInfo}</td>
        <td>STATUS</td>
        <td>{taskStatus}</td>
      </tr>
      <tr>
        <td>ROZPOCZĘTO</td>
        <td
          >{inspectionTask.startDateTime != "0001-01-01T00:00:00"
            ? setResultFormatIfItIsDateTime(
                "startDateTime",
                inspectionTask.startDateTime
              )
            : ""}</td
        >
      </tr>
      {#if taskStatus == "zakończone" || taskStatus == "zakonczone"}
        <tr>
          <td>ZAKOŃCZONO</td>
          <td
            >{inspectionTask.endDateTime != "0001-01-01T00:00:00"
              ? setResultFormatIfItIsDateTime(
                  "endDateTime",
                  inspectionTask.endDateTime
                )
              : ""}</td
          >
        </tr>
      {/if}
    </table>
  </div>
  <div />
{/if}
{#if multipleFamilyBuildingType}
  <div class="wielolokalowy">
    {#if firstListVisibility && collectionOfRealPropertiesWithoutAssignedProtocols.length > 0}
      <ModifiedBaseList
        {firstListName}
        collection={collectionOfRealPropertiesWithoutAssignedProtocols}
        headerDictionary={firstListHeaderDictionary}
        {firstTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="DODAJ PROTOKÓŁ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && taskStatus == "w toku"}
      <ModifiedBaseList
        {secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={secondListHeaderDictionary}
        {secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        secondButtonVisibility={true}
        secondButtonMessage="USUŃ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && (taskStatus == "zakonczone" || taskStatus == "zakończone")}
      <ModifiedBaseList
        {secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={secondListHeaderDictionary}
        {secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
  </div>
{/if}
{#if singleFamilyBuildingType}
  <div class="jednolokalowy">
    {#if firstListVisibility && collectionOfRealPropertiesWithoutAssignedProtocols.length > 0}
      <button
        on:click|preventDefault={FIRST_LIST_firstButtonHandler}
        class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
        >Dodaj protokół</button
      >
    {/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && taskStatus == "w toku"}
      <ModifiedBaseList
        {secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={singleFamilyBuildingHeaderDictionary}
        {secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        secondButtonVisibility={true}
        secondButtonMessage="USUŃ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && (taskStatus == "zakonczone" || taskStatus == "zakończone")}
      <ModifiedBaseList
        {secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={singleFamilyBuildingHeaderDictionary}
        {secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
  </div>
{/if} -->
